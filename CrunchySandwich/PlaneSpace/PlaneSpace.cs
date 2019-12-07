using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public struct PlaneSpace
    {
        public readonly Plane plane;

        public readonly Vector3 x;
        public readonly Vector3 y;
        public readonly Vector3 origin;

        public PlaneSpace(Plane p)
        {
            plane = p;

            Quaternion direction = Quaternion.LookRotation(plane.normal);

            x = direction * Vector3.right;
            y = direction * Vector3.up;
            origin = plane.GetOrigin();
        }
    }
}