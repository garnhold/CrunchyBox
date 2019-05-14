using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class GraphNodeNavigatorGoal_GraphNode<T> : GraphNodeNavigatorGoal<T> where T : GraphNode<T>
    {
        private T goal_node;

        public override bool IsGoal(GraphNodeNavigatorVisit<T> visit)
        {
            if (visit.GetGraphNode().Equals(goal_node))
                return true;

            return false;
        }

        public override double CalculateHeuristicCostEstimate(T node)
        {
            return goal_node.CalculateHeuristicCostEstimate(node);
        }

        public GraphNodeNavigatorGoal_GraphNode(T g)
        {
            goal_node = g;
        }
    }
}