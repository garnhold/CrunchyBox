using System;

namespace Crunchy.Bun
{
    public class RandVectorF2Box_Between : RandVectorF2Box
    {
        private VectorF2 a;
        private VectorF2 b;

        public RandVectorF2Box_Between(VectorF2 na, VectorF2 nb, RandVectorF2Source s) : base(s)
        {
            a = na;
            b = nb;
        }

        public RandVectorF2Box_Between(VectorF2 na, VectorF2 nb) : this(na, nb, RandVectorF2.SOURCE) { }

        public override VectorF2 Get()
        {
            return GetSource().GetBetween(a, b);
        }
    }
}