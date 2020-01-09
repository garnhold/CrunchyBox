using System;

namespace Crunchy.Bun
{
    using Dough;
    using Noodle;
    
    public struct VectorI2
    {
        public readonly int x;
        public readonly int y;

        static public readonly VectorI2 ONE = new VectorI2(1);
        static public readonly VectorI2 ZERO = new VectorI2(0);

        static public readonly VectorI2 UP = new VectorI2(0, 1);
        static public readonly VectorI2 DOWN = new VectorI2(0, -1);

        static public readonly VectorI2 LEFT = new VectorI2(-1, 0);
        static public readonly VectorI2 RIGHT = new VectorI2(1, 0);

        static public VectorI2 operator -(VectorI2 v) { return new VectorI2(-v.x, -v.y); }

        static public VectorI2 operator +(VectorI2 v1, VectorI2 v2) { return new VectorI2(v1.x + v2.x, v1.y + v2.y); }
        static public VectorI2 operator -(VectorI2 v1, VectorI2 v2) { return new VectorI2(v1.x - v2.x, v1.y - v2.y); }

        static public VectorI2 operator *(VectorI2 v1, int s) { return new VectorI2(v1.x * s, v1.y * s); }
        static public VectorI2 operator *(int s, VectorI2 v1) { return v1 * s; }
        static public VectorI2 operator /(VectorI2 v1, int s) { return new VectorI2(v1.x / s, v1.y / s); }

        static public VectorI2 operator *(VectorI2 v1, float s) { return new VectorI2(v1.x * s, v1.y * s); }
        static public VectorI2 operator *(float s, VectorI2 v1) { return v1 * s; }
        static public VectorI2 operator /(VectorI2 v1, float s) { return new VectorI2(v1.x / s, v1.y / s); }

        static public bool operator ==(VectorI2 p1, VectorI2 p2)
        {
            return p1.EqualsEX(p2);
        }
        static public bool operator !=(VectorI2 p1, VectorI2 p2)
        {
            return p1.NotEqualsEX(p2);
        }

        static public implicit operator VectorF2(VectorI2 item)
        {
            return item.GetVectorF2();
        }

        public VectorI2(int nx, int ny)
        {
            x = nx;
            y = ny;
        }

        public VectorI2(float nx, float ny) : this((int)nx, (int)ny) { }

        public VectorI2(int v) : this(v, v) { }
        public VectorI2(float v) : this(v, v) { }

        public float GetMagnitude()
        {
            return Mathq.Sqrt(GetSquaredMagnitude());
        }

        public int GetSquaredMagnitude()
        {
            return x*x + y*y;
        }

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
            VectorI2 cast;

            if (obj.Convert<VectorI2>(out cast))
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