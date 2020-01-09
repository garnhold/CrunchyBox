using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public interface GraphNode<T> where T : GraphNode<T>
    {
        double GetDistanceToGraphNode(T node);
        double CalculateHeuristicCostEstimate(T node);

        IEnumerable<T> GetConnectedGraphNodes();
    }
}