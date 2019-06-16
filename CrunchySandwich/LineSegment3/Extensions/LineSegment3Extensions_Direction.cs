using System;

using UnityEngine;

namespace CrunchySandwich
{
    static public class LineSegment3Extensions_Direction
    {
        static public Vector3 GetDirection(this LineSegment3 item)
        {
            return item.v0.GetDirection(item.v1);
        }

        static public Vector3 GetDirection(this LineSegment3 item, out float length)
        {
            return item.v0.GetDirection(item.v1, out length);
        }
    }
}