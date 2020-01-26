using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector2Extensions_Distance
    {
        static public float GetDistanceTo(this Vector2 item, Vector2 point)
        {
            return (point - item).GetMagnitude();
        }

        static public float GetSquaredDistanceTo(this Vector2 item, Vector2 point)
        {
            return (point - item).GetSquaredMagnitude();
        }

        static public bool IsWithinSquaredDistance(this Vector2 item, Vector2 point, float squared_distance)
        {
            if (item.GetSquaredDistanceTo(point) <= squared_distance)
                return true;

            return false;
        }

        static public bool IsWithinDistance(this Vector2 item, Vector2 point, float distance)
        {
            distance = distance.BindAbove(0.0f);

            return item.IsWithinSquaredDistance(point, distance * distance);
        }

        static public bool IsOutsideSquaredDistance(this Vector2 item, Vector2 point, float squared_distance)
        {
            if (item.IsWithinSquaredDistance(point, squared_distance) == false)
                return true;

            return false;
        }

        static public bool IsOutsideDistance(this Vector2 item, Vector2 point, float distance)
        {
            if (item.IsWithinDistance(point, distance) == false)
                return true;

            return false;
        }
    }
}