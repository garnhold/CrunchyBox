using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class GraphNodeNavigatorGoal<T> where T : GraphNode<T>
    {
        public abstract bool IsGoal(GraphNodeNavigatorVisit<T> visit);
        public abstract double CalculateHeuristicCostEstimate(T node);
    }
}