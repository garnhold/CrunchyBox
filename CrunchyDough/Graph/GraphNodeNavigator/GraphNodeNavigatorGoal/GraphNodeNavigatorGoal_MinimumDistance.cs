using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class GraphNodeNavigator_MinimumDistance<T> : GraphNodeNavigatorGoal<T> where T : GraphNode<T>
    {
        private double minimum_distance;

        public override bool IsGoal(GraphNodeNavigatorVisit<T> visit)
        {
            if (visit.GetTotalDistance() >= minimum_distance)
                return true;

            return false;
        }

        public override double CalculateHeuristicCostEstimate(T node)
        {
            return 0.0;
        }

        public GraphNodeNavigator_MinimumDistance(double m)
        {
            minimum_distance = m;
        }
    }
}