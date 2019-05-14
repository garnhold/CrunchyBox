using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    static public class VectorF2Extensions_Distance
    {
        static public float GetDistanceTo(this VectorF2 item, VectorF2 point)
        {
            return (point - item).GetMagnitude();
        }

        static public float GetSquaredDistanceTo(this VectorF2 item, VectorF2 point)
        {
            return (point - item).GetSquaredMagnitude();
        }

        static public bool IsWithinSquaredDistance(this VectorF2 item, VectorF2 point, float squared_distance)
        {
            if (item.GetSquaredDistanceTo(point) <= squared_distance)
                return true;

            return false;
        }

        static public bool IsWithinDistance(this VectorF2 item, VectorF2 point, float distance)
        {
            distance = distance.BindAbove(0.0f);

            return item.IsWithinSquaredDistance(point, distance * distance);
        }

        static public bool IsOutsideSquaredDistance(this VectorF2 item, VectorF2 point, float squared_distance)
        {
            if (item.IsWithinSquaredDistance(point, squared_distance) == false)
                return true;

            return false;
        }

        static public bool IsOutsideDistance(this VectorF2 item, VectorF2 point, float distance)
        {
            if (item.IsWithinDistance(point, distance) == false)
                return true;

            return false;
        }
    }
}