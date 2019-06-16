using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class LineSegment2Extensions_Ray
    {
        static public Ray2 GetRay(this LineSegment2 item)
        {
            return new Ray2(item.v0, item.v1 - item.v0);
        }
    }
}