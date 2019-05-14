using System;

using UnityEngine;

namespace CrunchySandwich
{
    public struct Triangle2
    {
        public readonly Vector2 v0;
        public readonly Vector2 v1;
        public readonly Vector2 v2;

        public Triangle2(Vector2 nv0, Vector2 nv1, Vector2 nv2)
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