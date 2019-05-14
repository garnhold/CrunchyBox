using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    public class GraphNodeWanderer_AngleLimited_Degrees<T> : GraphNodeWanderer_AngleLimited<T> where T : GraphNode_AngleAware_Degrees<T>
    {
        protected override float GetAngleBetweenGraphNodes(T node1, T node2)
        {
            return node1.GetAngleInDegreesToGraphNode(node2);
        }

        protected override float GetAngleDistance(float angle1, float angle2)
        {
            return angle1.GetDegreeAngleDistance(angle2);
        }

        public GraphNodeWanderer_AngleLimited_Degrees(T s, float d, float a) : base(s, d, a)
        {
        }
    }
}