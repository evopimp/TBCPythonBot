﻿using Core.Goals;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Core.GOAP
{
    /**
	 * Plans what actions can be completed in order to fulfill a goal state.
	 */

    public class GoapPlanner
    {
        private ILogger logger;

        public GoapPlanner(ILogger logger)
        {
            this.logger = logger;
        }

        public static void RefreshState(IEnumerable<GoapGoal> availableActions)
        {
            foreach (GoapGoal a in availableActions)
            {
                a.SetState(InState(a.Preconditions, new HashSet<KeyValuePair<GoapKey, object>>()));
            }
        }

        /**
		 * Plan what sequence of actions can fulfill the goal.
		 * Returns null if a plan could not be found, or a list of the actions
		 * that must be performed, in order, to fulfill the goal.
		 */

        public Queue<GoapGoal> Plan(IEnumerable<GoapGoal> availableActions,
                                      HashSet<KeyValuePair<GoapKey, object>> worldState,
                                      HashSet<KeyValuePair<GoapKey, GoapPreCondition>> goal)
        {
            // reset the actions so we can start fresh with them
            foreach (GoapGoal a in availableActions)
            {
                a.ResetBeforePlanning();
            }

            Node start = new Node(null, 0, worldState, null);

            // check what actions can run using their checkProceduralPrecondition
            HashSet<GoapGoal> usableActions = new HashSet<GoapGoal>();
            foreach (GoapGoal a in availableActions)
            {
                if (a.CheckIfActionCanRun())
                {
                    usableActions.Add(a);
                }
                else
                {
                    a.SetState(InState(a.Preconditions, start.state));
                }
            }

            // we now have all actions that can run, stored in usableActions

            // build up the tree and record the leaf nodes that provide a solution to the goal.
            List<Node> leaves = new List<Node>();

            // build graph
            bool success = BuildGraph(start, leaves, usableActions, goal);

            if (!success)
            {
                // oh no, we didn't get a plan
                logger.LogInformation("NO PLAN");

                return new Queue<GoapGoal>();
            }

            // get the cheapest leaf
            Node? cheapest = null;
            foreach (Node leaf in leaves)
            {
                if (cheapest == null)
                {
                    cheapest = leaf;
                }
                else
                {
                    if (leaf.runningCost < cheapest.runningCost)
                        cheapest = leaf;
                }
            }

            // get its node and work back through the parents
            List<GoapGoal> result = new List<GoapGoal>();
            Node? n = cheapest;
            while (n != null)
            {
                if (n.action != null)
                {
                    result.Insert(0, n.action); // insert the action in the front
                }
                n = n.parent;
            }
            // we now have this action list in correct order

            Queue<GoapGoal> queue = new Queue<GoapGoal>();
            foreach (GoapGoal a in result)
            {
                queue.Enqueue(a);
            }

            // hooray we have a plan!
            return queue;
        }

        /**
		 * Returns true if at least one solution was found.
		 * The possible paths are stored in the leaves list. Each leaf has a
		 * 'runningCost' value where the lowest cost will be the best action
		 * sequence.
		 */

        private bool BuildGraph(Node parent, List<Node> leaves, HashSet<GoapGoal> usableActions, HashSet<KeyValuePair<GoapKey, GoapPreCondition>> goal)
        {
            bool foundOne = false;

            // go through each action available at this node and see if we can use it here
            foreach (GoapGoal action in usableActions)
            {
                // if the parent state has the conditions for this action's preconditions, we can use it here
                var result = InState(action.Preconditions, parent.state);
                action.SetState(result);

                if (!result.ContainsValue(false))
                {
                    // apply the action's effects to the parent state
                    var currentState = PopulateState(parent.state, action.Effects);
                    //Debug.Log(GoapAgent.prettyPrint(currentState));
                    var node = new Node(parent, parent.runningCost + action.CostOfPerformingAction, currentState, action);

                    result = InState(goal, currentState);
                    if (!result.ContainsValue(false))
                    {
                        // we found a solution!
                        leaves.Add(node);
                        foundOne = true;
                    }
                    else
                    {
                        // not at a solution yet, so test all the remaining actions and branch out the tree
                        HashSet<GoapGoal> subset = ActionSubset(usableActions, action);
                        bool found = BuildGraph(node, leaves, subset, goal);
                        if (found)
                        {
                            foundOne = true;
                        }
                    }
                }
            }

            return foundOne;
        }

        /**
		 * Create a subset of the actions excluding the removeMe one. Creates a new set.
		 */

        private static HashSet<GoapGoal> ActionSubset(HashSet<GoapGoal> actions, GoapGoal removeMe)
        {
            HashSet<GoapGoal> subset = new HashSet<GoapGoal>();
            foreach (GoapGoal a in actions)
            {
                if (!a.Equals(removeMe))
                    subset.Add(a);
            }
            return subset;
        }

        /**
		 * Check that all items in 'test' are in 'state'. If just one does not match or is not there
		 * then this returns false.
		 */

        private static Dictionary<string, bool> InState(HashSet<KeyValuePair<GoapKey, GoapPreCondition>> test, HashSet<KeyValuePair<GoapKey, object>> state)
        {
            var resultState = new Dictionary<string, bool>();
            foreach (KeyValuePair<GoapKey, GoapPreCondition> t in test)
            {
                bool found = false;
                foreach (KeyValuePair<GoapKey, object> s in state)
                {
                    found = s.Key == t.Key;
                    if (found)
                    {
                        resultState.Add(t.Value.Description, s.Value.Equals(t.Value.State));
                        break;
                    }
                }

                if (!found)
                {
                    resultState.Add(t.Value.Description, false);
                }
            }
            return resultState;
        }

        /**
		 * Apply the stateChange to the currentState
		 */

        private static HashSet<KeyValuePair<GoapKey, object>> PopulateState(HashSet<KeyValuePair<GoapKey, object>> currentState, HashSet<KeyValuePair<GoapKey, object>> stateChange)
        {
            HashSet<KeyValuePair<GoapKey, object>> state = new HashSet<KeyValuePair<GoapKey, object>>();
            // copy the KVPs over as new objects
            foreach (KeyValuePair<GoapKey, object> s in currentState)
            {
                state.Add(new KeyValuePair<GoapKey, object>(s.Key, s.Value));
            }

            foreach (KeyValuePair<GoapKey, object> change in stateChange)
            {
                // if the key exists in the current state, update the Value
                bool exists = false;

                foreach (KeyValuePair<GoapKey, object> s in state)
                {
                    if (s.Equals(change))
                    {
                        exists = true;
                        break;
                    }
                }

                if (exists)
                {
                    state.RemoveWhere((KeyValuePair<GoapKey, object> kvp) => { return kvp.Key.Equals(change.Key); });
                    KeyValuePair<GoapKey, object> updated = new KeyValuePair<GoapKey, object>(change.Key, change.Value);
                    state.Add(updated);
                }
                // if it does not exist in the current state, add it
                else
                {
                    state.Add(new KeyValuePair<GoapKey, object>(change.Key, change.Value));
                }
            }
            return state;
        }

        /**
		 * Used for building up the graph and holding the running costs of actions.
		 */

        private class Node
        {
            public Node? parent;
            public float runningCost;
            public HashSet<KeyValuePair<GoapKey, object>> state;
            public GoapGoal? action;

            public Node(Node? parent, float runningCost, HashSet<KeyValuePair<GoapKey, object>> state, GoapGoal? action)
            {
                this.parent = parent;
                this.runningCost = runningCost;
                this.state = state;
                this.action = action;
            }
        }
    }
}