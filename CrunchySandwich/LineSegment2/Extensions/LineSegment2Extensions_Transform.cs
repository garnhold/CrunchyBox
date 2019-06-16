using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class LineSegment2Extensions_Transform
    {
        static public LineSegment2 GetReversed(this LineSegment2 item)
        {
            return new LineSegment2(item.v1, item.v0);
        }
    }
}