using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public struct Plane2
    {
        public readonly Vector2 normal;
        public readonly float distance;

        public Plane2(Vector2 n, float d)
        {
            normal = n.GetNormalized();
            distance = d;
        }
    }
}