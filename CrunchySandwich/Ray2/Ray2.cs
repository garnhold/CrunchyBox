using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public struct Ray2
    {
        public readonly Vector2 origin;
        public readonly Vector2 direction;

        public Ray2(Vector2 o, Vector2 d)
        {
            origin = o;
            direction = d.GetNormalized();
        }
    }
}