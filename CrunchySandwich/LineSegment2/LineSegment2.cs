using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public struct LineSegment2
    {
        public readonly Vector2 v0;
        public readonly Vector2 v1;

        public LineSegment2(Vector2 nv0, Vector2 nv1)
        {
            v0 = nv0;
            v1 = nv1;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + v0.GetHashCodeEX();
                hash = hash * 23 + v1.GetHashCodeEX();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            LineSegment2 cast;

            if (obj.Convert<LineSegment2>(out cast))
            {
                if (cast.v0.Equals(v0))
                {
                    if (cast.v1.Equals(v1))
                        return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            return "(" + v0 + ", " + v1 + ")";
        }
    }
}