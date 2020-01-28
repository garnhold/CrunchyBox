using System;

namespace Crunchy.Dough
{
    public struct RectI2
    {
        public readonly VectorI2 min;
        public readonly VectorI2 max;

        static public readonly RectI2 ZERO = new RectI2(VectorI2.ZERO, VectorI2.ZERO);

        public RectI2(VectorI2 np1, VectorI2 np2)
        {
            np1.Order(np2, out min, out max);
        }

        public override string ToString()
        {
            return "Min:" + min + " Max:" + max;
        }
    }
}