using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    public class GraphNodeWanderer_Random<T> : GraphNodeWanderer<T> where T : GraphNode<T>
    {
        private HashSet<T> node_set;

        protected override bool IsNodeValid(T to_check, IList<T> path)
        {
            if (node_set.Contains(to_check) == false)
                return true;

            return false;
        }

        protected override void OnNodeAdded(T added, IList<T> path)
        {
            node_set.Add(added);
        }

        public GraphNodeWanderer_Random(T s, float d) : base(s, d)
        {
            node_set = new HashSet<T>();
        }
    }
}