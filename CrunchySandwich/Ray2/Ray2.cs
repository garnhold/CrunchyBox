using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
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