using System;

namespace Crunchy.Dough
{
    public class RandVectorI2Box_Between : RandVectorI2Box
    {
        private VectorI2 a;
        private VectorI2 b;

        public RandVectorI2Box_Between(VectorI2 na, VectorI2 nb, RandVectorI2Source s) : base(s)
        {
            a = na;
            b = nb;
        }

        public RandVectorI2Box_Between(VectorI2 na, VectorI2 nb) : this(na, nb, RandVectorI2.SOURCE) { }

        public override VectorI2 Get()
        {
            return GetSource().GetBetween(a, b);
        }
    }
}