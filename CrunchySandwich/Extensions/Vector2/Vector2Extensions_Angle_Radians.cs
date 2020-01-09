using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class Vector2Extensions_Angle_Radians
    {
        static public Vector2 CreateDirection(float radians)
        {
            return new Vector2(TrigRadian.Cos(radians), TrigRadian.Sin(radians));
        }

        static public float GetAngleInRadians(this Vector2 item)
        {
            return TrigRadian.Atan2(item.y, item.x);
        }

        static public float GetAngleInRadiansDifference(this Vector2 item, Vector2 other)
        {
            return item.GetAngleInRadians().GetRadianAngleDifference(other.GetAngleInRadians());
        }

        static public float GetAngleInRadiansDistance(this Vector2 item, Vector2 other)
        {
            return item.GetAngleInRadians().GetRadianAngleDistance(other.GetAngleInRadians());
        }

        static public Vector2 GetAdjustDirectionAngleInRadians(this Vector2 item, float adjustment)
        {
            return CreateDirection(item.GetAngleInRadians() + adjustment);
        }

        static public Vector2 GetJitteredDirectionAngleInRadians(this Vector2 item, float magnitude)
        {
            return item.GetAdjustDirectionAngleInRadians(RandFloat.GetMagnitude(magnitude));
        }
    }
}