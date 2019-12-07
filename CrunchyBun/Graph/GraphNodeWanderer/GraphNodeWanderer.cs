using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    public abstract class GraphNodeWanderer<T> : GraphNodeTraverser<T> where T : GraphNode<T>
    {
        private float target_distance;

        private List<T> path;
        private float total_distance;

        protected abstract bool IsNodeValid(T to_check, IList<T> path);
        protected virtual void OnNodeAdded(T added, IList<T> path) { }

        private bool AddNode(T n)
        {
            if (IsNodeValid(n, path))
            {
                T previous_node;

                if (path.TryGetLast(out previous_node))
                    total_distance += (float)previous_node.GetDistanceToGraphNode(n);

                path.Add(n);
                OnNodeAdded(n, path);
                return true;
            }

            return false;
        }

        protected override bool WorkInternal()
        {
            return path.GetLast().GetConnectedGraphNodes().Randomize().Has(n => AddNode(n));
        }

        protected override bool IsCompleteInternal()
        {
            if (total_distance >= target_distance)
                return true;

            return false;
        }

        protected override IEnumerable<T> GetPathInternal()
        {
            return path;
        }

        public GraphNodeWanderer(T s, float d)
        {
            target_distance = d;

            path = new List<T>();
            total_distance = 0.0f;

            AddNode(s);
        }
    }
}