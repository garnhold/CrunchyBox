using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class LineSegment2Extensions_Length
    {
        static public float GetLength(this LineSegment2 item)
        {
            return item.v0.GetDistanceTo(item.v1);
        }
    }
}