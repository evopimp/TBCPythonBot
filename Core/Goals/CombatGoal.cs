﻿using Core.GOAP;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Goals
{
    public class CombatGoal : GoapGoal
    {
        public override float CostOfPerformingAction { get => 4f; }

        private readonly ILogger logger;
        private readonly ConfigurableInput input;

        private readonly PlayerReader playerReader;
        private readonly StopMoving stopMoving;
        private readonly CastingHandler castingHandler;
        
        private DateTime lastActive = DateTime.Now;
        private readonly ClassConfiguration classConfiguration;
        private DateTime lastPulled = DateTime.Now;

        private int lastKilledGuid;

        public CombatGoal(ILogger logger, ConfigurableInput input, PlayerReader playerReader, StopMoving stopMoving,  ClassConfiguration classConfiguration, CastingHandler castingHandler)
        {
            this.logger = logger;
            this.input = input;

            this.playerReader = playerReader;
            this.stopMoving = stopMoving;
            
            this.classConfiguration = classConfiguration;
            this.castingHandler = castingHandler;

            lastKilledGuid = playerReader.LastKilledGuid;

            AddPrecondition(GoapKey.incombat, true);
            AddPrecondition(GoapKey.hastarget, true);
            AddPrecondition(GoapKey.targetisalive, true);
            AddPrecondition(GoapKey.incombatrange, true);

            AddEffect(GoapKey.producedcorpse, true);
            AddEffect(GoapKey.targetisalive, false);
            AddEffect(GoapKey.hastarget, false);

            this.classConfiguration.Combat.Sequence.Where(k => k != null).ToList().ForEach(key => this.Keys.Add(key));
        }

        protected async Task Fight()
        {
            //logger.LogInformation("-");
            if ((DateTime.Now - lastActive).TotalSeconds > 5)
            {
                classConfiguration.Interact.ResetCooldown();
            }

            if(playerReader.PlayerBitValues.HasPet && !playerReader.PetHasTarget)
            {
                await input.TapPetAttack("");
            }

            bool pressed = false;
            foreach (var item in this.Keys)
            {
                bool isFightold=(DateTime.Now - lastActive).TotalSeconds > 5 && (DateTime.Now - lastPulled).TotalSeconds > 5;
                if (item.Name == "Interact" && !isFightold) // don't interact at the start of the fight
                {
                    item.SetClicked();
                    continue;
                }

                pressed = await this.castingHandler.CastIfReady(item);
                if (pressed)
                {
                    break;
                }
            }
            if (!pressed)
            {
                await Task.Delay(20);
            }

            this.lastActive = DateTime.Now;
        }

        public override void OnActionEvent(object sender, ActionEventArgs e)
        {
            if (e.Key == GoapKey.newtarget)
            {
                logger.LogInformation("?Reset cooldowns");

                ResetCooldowns();
            }

            if (e.Key == GoapKey.pulled)
            {
                this.lastPulled = DateTime.Now;
            }
        }

        private void ResetCooldowns()
        {
            this.classConfiguration.Combat.Sequence
            .Where(i => i.ResetOnNewTarget)
            .ToList()
            .ForEach(item =>
            {
                logger.LogInformation($"Reset cooldown on {item.Name}");
                item.ResetCooldown();
                item.ResetCharges();
            });
        }

        protected bool HasPickedUpAnAdd
        {
            get
            {
                return this.playerReader.PlayerBitValues.PlayerInCombat &&
                    !this.playerReader.PlayerBitValues.TargetOfTargetIsPlayer
                    && this.playerReader.TargetHealthPercentage == 100;
            }
        }

        public override async Task PerformAction()
        {
            if (playerReader.PlayerBitValues.IsMounted)
            {
                await input.Dismount();
            }

            /*
            if (HasPickedUpAnAdd)
            {
                logger.LogInformation($"Combat={this.playerReader.PlayerBitValues.PlayerInCombat}, Is Target targetting me={this.playerReader.PlayerBitValues.TargetOfTargetIsPlayerOrPet}");
                logger.LogInformation($"Add on combat");
                await this.stopMoving.Stop();
                await wowProcess.TapStopKey();
                await wowProcess.TapClearTarget();
                return;
            }
            */

            if ((DateTime.Now - lastActive).TotalSeconds > 5 && (DateTime.Now - lastPulled).TotalSeconds > 5)
            {
                await input.TapInteractKey($"{GetType().Name}: Interact and stop");
                await stopMoving.Stop();
            }

            await stopMoving.Stop();

            SendActionEvent(new ActionEventArgs(GoapKey.fighting, true));

            await this.castingHandler.InteractOnUIError();

            await Fight();
            await KillCheck();
            lastActive = DateTime.Now;
        }

        private async Task KillCheck()
        {
            if (DidKilledACreature())
            {
                if (!await CreatureTargetMeOrMyPet())
                {
                    logger.LogInformation("Exit CombatGoal!!!");
                }
            }
            await Task.Delay(0);
        }

        private bool DidKilledACreature()
        {
            if (lastKilledGuid != playerReader.LastKilledGuid)
            {
                logger.LogInformation($"----- A mob just died {playerReader.LastKilledGuid}");

                if ((playerReader.CombatCreatures.Any(x => x.CreatureId == playerReader.LastKilledGuid) || // creature dealt damage to me or my pet
                playerReader.TargetHistory.Any(x => x.CreatureId == playerReader.LastKilledGuid)))     // has ever targeted by the player)
                {
                    lastKilledGuid = playerReader.LastKilledGuid;

                    playerReader.IncrementKillCount();
                    logger.LogInformation($"----- Killed a mob! Current: {playerReader.LastCombatKillCount} - " + 
                        $"CombatCreature: {playerReader.CombatCreatures.Any(x => x.CreatureId == playerReader.LastKilledGuid)} - " + 
                        $"TargetHistory: {playerReader.TargetHistory.Any(x => x.CreatureId == playerReader.LastKilledGuid)}");

                    SendActionEvent(new ActionEventArgs(GoapKey.producedcorpse, true));
                    return true;
                }
            }

            return false;
        }

        private async Task<bool> CreatureTargetMeOrMyPet()
        {
            if (playerReader.PetHasTarget &&
                playerReader.LastKilledGuid != playerReader.PetTargetGuid)
            {
                logger.LogWarning("---- My pet has a target!");
                ResetCooldowns();

                await input.TapTargetPet();
                await input.TapTargetOfTarget();
                
                return playerReader.HasTarget;
            }

            // check for targets attacking me
            await input.TapNearestTarget();
            await playerReader.WaitForNUpdate(1);
            if (this.playerReader.HasTarget && playerReader.PlayerBitValues.TargetInCombat)
            {
                if (this.playerReader.PlayerBitValues.TargetOfTargetIsPlayer)
                {
                    ResetCooldowns();

                    logger.LogWarning("---- Somebody is attacking me!");
                    await input.TapInteractKey("Found new target to attack");
                    return true;
                }
            }

            if (await Wait(200, () => playerReader.HasTarget))
            {
                return true;
            }

            await input.TapClearTarget();
            logger.LogWarning("---- No Threat has been found!");

            return false;
        }
    }
}