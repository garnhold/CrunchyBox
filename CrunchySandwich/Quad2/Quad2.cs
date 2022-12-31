using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    public struct Quad2
    {
        public readonly Vector2 v0;
        public readonly Vector2 v1;
        public readonly Vector2 v2;
        public readonly Vector2 v3;

        public Quad2(Vector2 nv0, Vector2 nv1, Vector2 nv2, Vector2 nv3)
        {
            v0 = nv0;
            v1 = nv1;
            v2 = nv2;
            v3 = nv3;
        }

        public override string ToString()
        {
            return "(" + v0 + ", " + v1 + ", " + v2 + ", " + v3 + ")";
        }
    }
}