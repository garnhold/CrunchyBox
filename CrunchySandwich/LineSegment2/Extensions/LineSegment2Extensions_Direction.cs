using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class LineSegment2Extensions_Direction
    {
        static public Vector2 GetDirection(this LineSegment2 item)
        {
            return item.v0.GetDirection(item.v1);
        }

        static public Vector2 GetDirection(this LineSegment2 item, out float length)
        {
            return item.v0.GetDirection(item.v1, out length);
        }
    }
}