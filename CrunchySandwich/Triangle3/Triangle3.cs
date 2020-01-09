using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    public struct Triangle3
    {
        public readonly Vector3 v0;
        public readonly Vector3 v1;
        public readonly Vector3 v2;

        public Triangle3(Vector3 nv0, Vector3 nv1, Vector3 nv2)
        {
            v0 = nv0;
            v1 = nv1;
            v2 = nv2;
        }

        public override string ToString()
        {
            return "(" + v0 + ", " + v1 + ", " + v2 + ")";
        }
    }
}