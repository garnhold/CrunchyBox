using System;

using UnityEngine;

namespace CrunchySandwich
{
    static public class LineSegment3Extensions_Transform
    {
        static public LineSegment3 GetReverse(this LineSegment3 item)
        {
            return new LineSegment3(item.v1, item.v0);
        }
    }
}