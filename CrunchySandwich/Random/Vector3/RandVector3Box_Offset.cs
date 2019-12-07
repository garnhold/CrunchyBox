using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Bun;
    
    public class RandVector3Box_Offset : RandVector3Box
    {
        private Vector3 radius;

        public RandVector3Box_Offset(Vector3 r, RandVector3Source s) : base(s)
        {
            radius = r;
        }

        public RandVector3Box_Offset(Vector2 r) : this(r, RandVector3.SOURCE) { }

        public override Vector3 Get()
        {
            return GetSource().GetOffset(radius);
        }
    }
}