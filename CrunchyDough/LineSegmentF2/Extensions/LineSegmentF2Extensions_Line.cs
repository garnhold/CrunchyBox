using System;

namespace Crunchy.Dough
{
    static public class LineSegmentF2Extensions_Line
    {
        static public LineF2 GetLine(this LineSegmentF2 item)
        {
            return new LineF2(item.p1, item.p1.GetDirection(item.p2));
        }
    }
}