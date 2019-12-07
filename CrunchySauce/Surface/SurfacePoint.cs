using System;

namespace Crunchy.Sauce
{
    using Dough;
    
    public struct SurfacePoint
    {
        public readonly int x;
        public readonly int y;

        static public bool operator==(SurfacePoint p1, SurfacePoint p2)
        {
            return p1.Equals(p2);
        }

        static public bool operator !=(SurfacePoint p1, SurfacePoint p2)
        {
            return p1.NotEqualsEX(p2);
        }

        public SurfacePoint(int nx, int ny)
        {
            x = nx;
            y = ny;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + x;
                hash = hash * 23 + y;
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            SurfacePoint cast;

            if (obj.Convert<SurfacePoint>(out cast))
            {
                if (cast.x == x)
                {
                    if (cast.y == y)
                        return true;
                }
            }

            return false;
        }
    }
}