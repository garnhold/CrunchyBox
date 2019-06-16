using System;

using UnityEngine;

namespace CrunchySandwich
{
    static public class LineSegment3Extensions_Ray
    {
        static public Ray GetRay(this LineSegment3 item)
        {
            return new Ray(item.v0, item.v1 - item.v0);
        }
    }
}