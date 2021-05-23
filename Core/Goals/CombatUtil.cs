using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Core
{
    public class CombatUtil
    {
        private readonly ILogger logger;
        private readonly PlayerReader playerReader;
        private readonly ConfigurableInput input;

        private bool debug = true;

        private bool outOfCombat;
        private WowPoint lastPosition;

        public CombatUtil(ILogger logger, ConfigurableInput input, PlayerReader playerReader)
        {
            this.logger = logger;
            this.input = input;
            this.playerReader = playerReader;

            outOfCombat = !playerReader.PlayerBitValues.PlayerInCombat;
            lastPosition = playerReader.PlayerLocation;
        }

        public void Update()
        {
            // TODO: have to find a better way to reset outOfCombat
            outOfCombat = false;
            lastPosition = playerReader.PlayerLocation;
        }

        public async Task<bool> EnteredCombat()
        {
            await Task.Delay(1);
            if (!outOfCombat && !playerReader.PlayerBitValues.PlayerInCombat)
            {
                Log("Combat Leave");
                outOfCombat = true;
                return false;
            }

            if (outOfCombat && playerReader.PlayerBitValues.PlayerInCombat)
            {
                Log("Combat Enter");
                return true;
            }

            return false;
        }

        public async Task<bool> AquiredTarget()
        {
            if (this.playerReader.PlayerBitValues.PlayerInCombat)
            {
                if (this.playerReader.PetHasTarget)
                {
                    await input.TapTargetPet();
                    Log($"Pets target {this.playerReader.TargetTarget}");
                    if (this.playerReader.TargetTarget == TargetTargetEnum.PetHasATarget)
                    {
                        await input.TapTargetOfTarget($"{GetType().Name}.AquiredTarget: Found target by pet");
                        return true;
                    }
                }

                await input.TapNearestTarget();
                await playerReader.WaitForNUpdate(1);
                if (this.playerReader.HasTarget && playerReader.PlayerBitValues.TargetInCombat &&
                    playerReader.PlayerBitValues.TargetOfTargetIsPlayer)
                {
                    Log("Found from nearest target");
                    return true;
                }

                if (await Wait(200, () => playerReader.HasTarget))
                {
                    return true;
                }

                await input.TapClearTarget($"{GetType().Name}.AquiredTarget: No target found");
                await playerReader.WaitForNUpdate(1);
            }
            return false;
        }

        public bool IsPlayerMoving(WowPoint lastPos)
        {
            var distance = WowPoint.DistanceTo(lastPos, playerReader.PlayerLocation);
            return distance > 0.5f;
        }

        public async Task<Tuple<bool, bool>> FoundTargetWhileMoved()
        {
            bool hadToMove = false;
            if (IsPlayerMoving(lastPosition))
            {
                hadToMove = true;
                Log("Goto corpse - Wait till player become stil!");
            }

            while (IsPlayerMoving(lastPosition))
            {
                lastPosition = playerReader.PlayerLocation;
                if (!await Wait(200, EnteredCombat()))
                {
                    if (await AquiredTarget())
                        return Tuple.Create(true, hadToMove);
                }
            }

            if (hadToMove)
            {
                if (!await Wait(200, EnteredCombat()))
                {
                    if (await AquiredTarget())
                        return Tuple.Create(true, hadToMove);
                }
            }

            return Tuple.Create(false, hadToMove);
        }


        public static async Task<bool> Wait(int durationMs, Func<bool> exit)
        {
            int elapsedMs = 0;
            while (elapsedMs <= durationMs)
            {
                if (exit())
                    return false;

                await Task.Delay(50);
                elapsedMs += 50;
            }

            return true;
        }

        public static async Task<bool> Wait(int durationMs, Task<bool> exit)
        {
            int elapsedMs = 0;
            while (elapsedMs <= durationMs)
            {
                if (await exit)
                    return false;

                await Task.Delay(50);
                elapsedMs += 50;
            }

            return true;
        }


        private void Log(string text)
        {
            if (debug)
            {
                logger.LogInformation($"{GetType().Name}: {text}");
            }
        }
    }
}
