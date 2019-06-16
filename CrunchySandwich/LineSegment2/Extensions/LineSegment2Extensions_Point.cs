using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class LineSegment2Extensions_Point
    {
        static public IEnumerable<Vector2> GetPoints(this LineSegment2 item)
        {
            yield return item.v0;
            yield return item.v1;
        }

        static public Vector2 GetCenter(this LineSegment2 item)
        {
            return item.GetPoints().Average();
        }

        static public Vector2 GetPointOnByPercent(this LineSegment2 item, float percent)
        {
            return item.v0.GetPointOnLineSegmentByPercent(item.v1, percent);
        }

        static public Vector2 GetPointOnByDistance(this LineSegment2 item, float distance)
        {
            return item.v0.GetPointOnLineSegment(item.v1, distance);
        }
    }
}