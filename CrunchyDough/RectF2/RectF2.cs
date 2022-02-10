using System;

namespace Crunchy.Dough
{
    public struct RectF2
    {
        public readonly VectorF2 min;
        public readonly VectorF2 max;

        static public readonly RectF2 ZERO = new RectF2(VectorF2.ZERO, VectorF2.ZERO);

        static public bool operator ==(RectF2 p1, RectF2 p2)
        {
            return p1.EqualsEX(p2);
        }
        static public bool operator !=(RectF2 p1, RectF2 p2)
        {
            return p1.NotEqualsEX(p2);
        }

        public RectF2(VectorF2 np1, VectorF2 np2)
        {
            np1.Order(np2, out min, out max);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + min.GetHashCode();
                hash = hash * 23 + max.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            RectF2 cast;

            if (obj.Convert<RectF2>(out cast))
            {
                if (cast.min == min)
                {
                    if (cast.max == min)
                        return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            return "Min:" + min + " Max:" + max;
        }
    }
}