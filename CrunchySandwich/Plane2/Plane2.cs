using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
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