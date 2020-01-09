using System;

namespace Crunchy.Bun
{
    public struct LineF2
    {
        public readonly VectorF2 point;
        public readonly VectorF2 direction;

        public LineF2(VectorF2 p, VectorF2 d)
        {
            point = p;
            direction = d;
        }

        public override string ToString()
        {
            return "Point:" + point + " Direction:" + direction;
        }
    }
}