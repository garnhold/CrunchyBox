using System;

namespace CrunchyBun
{
    static public class LineF2Extensions_Point
    {
        static public VectorF2 GetPointAlong(this LineF2 item, float distance)
        {
            return item.point + item.direction * distance;
        }
    }
}