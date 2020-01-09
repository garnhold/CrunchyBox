using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class LineSegment3Extensions_Length
    {
        static public float GetLength(this LineSegment3 item)
        {
            return item.v0.GetDistanceTo(item.v1);
        }

        static public float GetSquaredLength(this LineSegment3 item)
        {
            return item.v0.GetSquaredDistanceTo(item.v1);
        }
    }
}