using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Bun;
    
    public class RandVector3Box_Variance : RandVector3Box
    {
        private Vector3 center;
        private Vector3 radius;

        public RandVector3Box_Variance(Vector3 c, Vector3 r, RandVector3Source s) : base(s)
        {
            center = c;
            radius = r;
        }

        public RandVector3Box_Variance(Vector2 c, Vector2 r) : this(c, r, RandVector3.SOURCE) { }

        public override Vector3 Get()
        {
            return GetSource().GetVariance(center, radius);
        }
    }
}