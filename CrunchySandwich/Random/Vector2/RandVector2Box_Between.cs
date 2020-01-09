using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Bun;
    
    public class RandVector2Box_Between : RandVector2Box
    {
        private Vector2 a;
        private Vector2 b;

        public RandVector2Box_Between(Vector2 na, Vector2 nb, RandVector2Source s) : base(s)
        {
            a = na;
            b = nb;
        }

        public RandVector2Box_Between(Vector2 na, Vector2 nb) : this(na, nb, RandVector2.SOURCE) { }

        public override Vector2 Get()
        {
            return GetSource().GetBetween(a, b);
        }
    }
}