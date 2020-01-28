using System;

namespace Crunchy.Dough
{    
    public struct VectorF2
    {
        public readonly float x;
        public readonly float y;

        static public readonly VectorF2 ONE = new VectorF2(1.0f);
        static public readonly VectorF2 HALF = new VectorF2(0.5f);
        static public readonly VectorF2 ZERO = new VectorF2(0.0f);

        static public readonly VectorF2 RIGHT = new VectorF2(1.0f, 0.0f);
        static public readonly VectorF2 RIGHT_UP = new VectorF2(Mathq.DIAGONAL, Mathq.DIAGONAL);
        static public readonly VectorF2 UP = new VectorF2(0.0f, 1.0f);
        static public readonly VectorF2 LEFT_UP = new VectorF2(-Mathq.DIAGONAL, Mathq.DIAGONAL);
        static public readonly VectorF2 LEFT = new VectorF2(-1.0f, 0.0f);
        static public readonly VectorF2 LEFT_DOWN = new VectorF2(-Mathq.DIAGONAL, -Mathq.DIAGONAL);
        static public readonly VectorF2 DOWN = new VectorF2(0.0f, -1.0f);
        static public readonly VectorF2 RIGHT_DOWN = new VectorF2(Mathq.DIAGONAL, -Mathq.DIAGONAL);

        static public VectorF2 operator -(VectorF2 v) { return new VectorF2(-v.x, -v.y); }

        static public VectorF2 operator +(VectorF2 v1, VectorF2 v2) { return new VectorF2(v1.x + v2.x, v1.y + v2.y); }
        static public VectorF2 operator -(VectorF2 v1, VectorF2 v2) { return new VectorF2(v1.x - v2.x, v1.y - v2.y); }

        static public VectorF2 operator *(VectorF2 v1, float s) { return new VectorF2(v1.x * s, v1.y * s); }
        static public VectorF2 operator *(float s, VectorF2 v1) { return v1 * s; }
        static public VectorF2 operator /(VectorF2 v1, float s) { return new VectorF2(v1.x / s, v1.y / s); }

        static public bool operator ==(VectorF2 p1, VectorF2 p2)
        {
            return p1.EqualsEX(p2);
        }
        static public bool operator !=(VectorF2 p1, VectorF2 p2)
        {
            return p1.NotEqualsEX(p2);
        }

        static public explicit operator VectorI2(VectorF2 item)
        {
            return item.GetVectorI2();
        }

        public VectorF2(float nx, float ny)
        {
            x = nx;
            y = ny;
        }

        public VectorF2(float v) : this(v, v) { }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + x.GetHashCode();
                hash = hash * 23 + y.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            VectorF2 cast;

            if (obj.Convert<VectorF2>(out cast))
            {
                if (cast.x.EqualsEX(x))
                {
                    if (cast.y.EqualsEX(y))
                        return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            return "<" + x + ", " + y + ">";
        }
    }
}