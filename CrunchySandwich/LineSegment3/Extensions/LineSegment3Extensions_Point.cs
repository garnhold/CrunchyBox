using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class LineSegment3Extensions_Point
    {
        static public IEnumerable<Vector3> GetPoints(this LineSegment3 item)
        {
            yield return item.v0;
            yield return item.v1;
        }

        static public Vector3 GetCenter(this LineSegment3 item)
        {
            return item.GetPoints().Average();
        }

        static public Vector3 GetPointOnByPercent(this LineSegment3 item, float percent)
        {
            return item.v0.GetPointOnLineSegmentByPercent(item.v1, percent);
        }

        static public Vector3 GetPointOnByDistance(this LineSegment3 item, float distance)
        {
            return item.v0.GetPointOnLineSegment(item.v1, distance);
        }
    }
}