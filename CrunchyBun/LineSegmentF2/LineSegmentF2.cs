using System;

namespace CrunchyBun
{
    public struct LineSegmentF2
    {
        public readonly VectorF2 p1;
        public readonly VectorF2 p2;

        public LineSegmentF2(VectorF2 np1, VectorF2 np2)
        {
            p1 = np1;
            p2 = np2;
        }

        public override string ToString()
        {
            return "Point1:" + p1 + " Point2:" + p2;
        }
    }
}