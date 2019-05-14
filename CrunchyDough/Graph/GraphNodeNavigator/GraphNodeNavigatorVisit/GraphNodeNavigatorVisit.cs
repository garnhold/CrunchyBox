
using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class GraphNodeNavigatorVisit<T> where T : GraphNode<T>
    {
        private T graph_node;
        private GraphNodeNavigatorVisit<T> parent_graph_node_visit;

        private double total_distance;
        private double heuristic_cost_estimate;

        static public GraphNodeNavigatorVisit<T> CreateInitial(T g, double h)
        {
            return new GraphNodeNavigatorVisit<T>(g, 0.0, h);
        }

        static public GraphNodeNavigatorVisit<T> CreateNormal(T g, double h)
        {
            return new GraphNodeNavigatorVisit<T>(g, double.PositiveInfinity, h);
        }

        private GraphNodeNavigatorVisit(T g, double d, double h)
        {
            graph_node = g;
            parent_graph_node_visit = null;

            total_distance = d;
            heuristic_cost_estimate = h;
        }

        public bool Update(GraphNodeNavigatorVisit<T> p, double d)
        {
            if (d < total_distance)
            {
                parent_graph_node_visit = p;

                total_distance = d;
                return true;
            }

            return false;
        }

        public T GetGraphNode()
        {
            return graph_node;
        }

        public GraphNodeNavigatorVisit<T> GetParentGraphNodeVisit()
        {
            return parent_graph_node_visit;
        }

        public double GetTotalDistance()
        {
            return total_distance;
        }

        public double GetTentativeTotalDistance(T node)
        {
            return GetTotalDistance() + graph_node.GetDistanceToGraphNode(node);
        }

        public double GetHeuristicCostEstimate()
        {
            return heuristic_cost_estimate;
        }

        public double GetTotalScore()
        {
            return GetTotalDistance() + GetHeuristicCostEstimate();
        }

        public IEnumerable<T> GetConnectedGraphNodes()
        {
            return graph_node.GetConnectedGraphNodes();
        }

        public IEnumerable<GraphNodeNavigatorVisit<T>> GetReverseGraphNodeVisitPath()
        {
            return this.TraverseWithSelf(v => v.GetParentGraphNodeVisit());
        }
        public IEnumerable<GraphNodeNavigatorVisit<T>> GetGraphNodeVisitPath()
        {
            return GetReverseGraphNodeVisitPath().Reverse();
        }

        public IEnumerable<T> GetReverseGraphNodePath()
        {
            return GetReverseGraphNodeVisitPath().Convert(v => v.GetGraphNode());
        }
        public IEnumerable<T> GetGraphNodePath()
        {
            return GetReverseGraphNodePath().Reverse();
        }
    }
}