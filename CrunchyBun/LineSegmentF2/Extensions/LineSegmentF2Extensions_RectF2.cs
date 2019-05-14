using System;

namespace CrunchyBun
{
    static public class LineSegmentF2Extensions_RectF2
    {
        static public RectF2 GetRectF2(this LineSegmentF2 item)
        {
            return new RectF2(item.p1, item.p2);
        }
    }
}