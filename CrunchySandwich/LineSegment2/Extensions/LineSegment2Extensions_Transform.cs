using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class LineSegment2Extensions_Transform
    {
        static public LineSegment2 GetReversed(this LineSegment2 item)
        {
            return new LineSegment2(item.v1, item.v0);
        }

        static public LineSegment2 GetTrimmed(this LineSegment2 item, float margin, out float length)
        {
            Vector2 direction = item.GetDirection(out length);

            return new LineSegment2(
                item.v0 + direction * margin,
                item.v1 - direction * margin
            );
        }
        static public LineSegment2 GetTrimmed(this LineSegment2 item, float margin)
        {
            float length;

            return item.GetTrimmed(margin, out length);
        }
    }
}