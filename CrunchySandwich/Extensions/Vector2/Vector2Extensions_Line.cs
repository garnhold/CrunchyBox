using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_Line
    {
        static public Vector2 GetNormal(this Vector2 item)
        {
            return new Vector2(-item.y, item.x);
        }
        static public Vector2 GetNormal(this Vector2 item, Vector2 point)
        {
            return (point - item).GetNormal();
        }

        static public Vector2 GetNormalizedNormal(this Vector2 item)
        {
            return item.GetNormal().normalized;
        }
        static public Vector2 GetNormalizedNormal(this Vector2 item, Vector2 point)
        {
            return (point - item).GetNormalizedNormal();
        }

        static public float GetDistanceToLine(this Vector2 item, Vector2 point1, Vector2 point2)
        {
            return point1.GetNormalizedNormal(point2).GetDot(item - point1).GetAbs();
        }
    }
}