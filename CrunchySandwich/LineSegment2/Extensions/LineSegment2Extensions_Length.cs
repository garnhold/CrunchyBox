using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class LineSegment2Extensions_Length
    {
        static public float GetLength(this LineSegment2 item)
        {
            return item.v0.GetDistanceTo(item.v1);
        }

        static public float GetSquaredLength(this LineSegment2 item)
        {
            return item.v0.GetSquaredDistanceTo(item.v1);
        }

        static public bool IsLengthWithin(this LineSegment2 item, float length)
        {
            return item.v0.IsWithinDistance(item.v1, length);
        }
    }
}