using System;

namespace CrunchyBun
{
    public struct RectF2
    {
        public readonly VectorF2 min;
        public readonly VectorF2 max;

        static public readonly RectF2 ZERO = new RectF2(VectorF2.ZERO, VectorF2.ZERO);

        public RectF2(VectorF2 np1, VectorF2 np2)
        {
            np1.Order(np2, out min, out max);
        }

        public override string ToString()
        {
            return "Min:" + min + " Max:" + max;
        }
    }
}