using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    public abstract class GraphNodeWanderer_AngleLimited<T> : GraphNodeWanderer<T> where T : GraphNode_AngleAware<T>
    {
        private float maximum_angle_delta;

        protected abstract float GetAngleBetweenGraphNodes(T node1, T node2);
        protected abstract float GetAngleDistance(float angle1, float angle2);

        protected override bool IsNodeValid(T to_check, IList<T> path)
        {
            if (path.Count >= 2)
            {
                T previous_node = path.GetFromEnd(0);
                T previous_previous_node = path.GetFromEnd(1);

                float angle = GetAngleBetweenGraphNodes(previous_node, to_check);
                float previous_angle = GetAngleBetweenGraphNodes(previous_previous_node, previous_node);

                if (GetAngleDistance(previous_angle, angle) <= maximum_angle_delta)
                    return true;

                return false;
            }

            if (path.Has(to_check) == false)
                return true;

            return false;
        }

        public GraphNodeWanderer_AngleLimited(T s, float d, float a) : base(s, d)
        {
            maximum_angle_delta = a;
        }
    }
}