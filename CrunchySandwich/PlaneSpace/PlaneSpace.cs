using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public struct PlaneSpace
    {
        public readonly Plane plane;

        public readonly Vector3 x;
        public readonly Vector3 y;
        public readonly Vector3 origin;

        static public implicit operator PlaneSpace(Plane p)
        {
            return new PlaneSpace(p);
        }
        static public implicit operator Plane(PlaneSpace p)
        {
            return p.plane;
        }

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