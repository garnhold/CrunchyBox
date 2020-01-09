using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class GraphNodeNavigator<T> : GraphNodeTraverser<T> where T : GraphNode<T>
    {
        private T start_node;
        private GraphNodeNavigatorGoal<T> goal;

        private LinkedList<GraphNodeNavigatorVisit<T>> visits;

        private HashSet<T> closed_set;
        private Dictionary<T, GraphNodeNavigatorVisit<T>> open_set;

        private void Grow(GraphNodeNavigatorVisit<T> parent, T node)
        {
            if (closed_set.Contains(node) == false)
            {
                double total_distance = parent.GetTentativeTotalDistance(node);

                GraphNodeNavigatorVisit<T> visit = open_set.GetOrCreateValue(node, 
                    n => GraphNodeNavigatorVisit<T>.CreateNormal(n, goal.CalculateHeuristicCostEstimate(n))
                );

                if (visit.Update(parent, total_distance))
                    AddVisit(visit);
            }
        }

        private void AddVisit(GraphNodeNavigatorVisit<T> to_add)
        {
            visits.Remove(to_add);

            visits.InsertBefore(to_add, v => to_add.GetTotalScore() < v.GetTotalScore());
            open_set[to_add.GetGraphNode()] = to_add;
        }

        private void RemoveVisit(GraphNodeNavigatorVisit<T> to_remove)
        {
            visits.Remove(to_remove);

            closed_set.Add(to_remove.GetGraphNode());
            open_set.Remove(to_remove.GetGraphNode());
        }

        protected override bool WorkInternal()
        {
            if (open_set.IsNotEmpty())
            {
                GraphNodeNavigatorVisit<T> current_visit = visits.GetFirst();

                RemoveVisit(current_visit);
                foreach (T sub_node in current_visit.GetConnectedGraphNodes())
                    Grow(current_visit, sub_node);

                return true;
            }

            return false;
        }

        protected override bool IsCompleteInternal()
        {
            if (goal.IsGoal(visits.GetFirst()))
                return true;

            return false;
        }

        protected override IEnumerable<T> GetPathInternal()
        {
            return visits.GetFirst().GetGraphNodePath();
        }

        public GraphNodeNavigator(T s, GraphNodeNavigatorGoal<T> g)
        {
            start_node = s;
            goal = g;

            visits = new LinkedList<GraphNodeNavigatorVisit<T>>();

            closed_set = new HashSet<T>();
            open_set = new Dictionary<T, GraphNodeNavigatorVisit<T>>();

            AddVisit(GraphNodeNavigatorVisit<T>.CreateInitial(start_node, goal.CalculateHeuristicCostEstimate(start_node)));
        }
    }
}