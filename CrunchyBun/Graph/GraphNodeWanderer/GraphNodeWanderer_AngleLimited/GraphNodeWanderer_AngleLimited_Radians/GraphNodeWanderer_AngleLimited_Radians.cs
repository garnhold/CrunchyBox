using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    public class GraphNodeWanderer_AngleLimited_Radians<T> : GraphNodeWanderer_AngleLimited<T> where T : GraphNode_AngleAware_Radians<T>
    {
        protected override float GetAngleBetweenGraphNodes(T node1, T node2)
        {
            return node1.GetAngleInRadiansToGraphNode(node2);
        }

        protected override float GetAngleDistance(float angle1, float angle2)
        {
            return angle1.GetRadianAngleDistance(angle2);
        }

        public GraphNodeWanderer_AngleLimited_Radians(T s, float d, float a) : base(s, d, a)
        {
        }
    }
}