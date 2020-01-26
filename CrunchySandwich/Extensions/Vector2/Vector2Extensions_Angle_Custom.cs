using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector2Extensions_Angle_Custom
    {
        static public Vector2 CreateDirection(float x, float period)
        {
            return new Vector2(TrigCustom.Cos(x, period), TrigCustom.Sin(x, period));
        }

        static public float GetAngleInCustom(this Vector2 item, float period)
        {
            return TrigCustom.Atan2(item.y, item.x, period);
        }

        static public float GetAngleInCustomDifference(this Vector2 item, Vector2 other, float period)
        {
            return item.GetAngleInCustom(period).GetAngleDifference(other.GetAngleInCustom(period), period);
        }

        static public float GetAngleInCustomDistance(this Vector2 item, Vector2 other, float period)
        {
            return item.GetAngleInCustom(period).GetAngleDistance(other.GetAngleInCustom(period), period);
        }

        static public Vector2 GetAdjustDirectionAngleInCustom(this Vector2 item, float adjustment, float period)
        {
            return CreateDirection(item.GetAngleInCustom(period) + adjustment, period);
        }

        static public Vector2 GetJitteredDirectionAngleInCustom(this Vector2 item, float magnitude, float period)
        {
            return item.GetAdjustDirectionAngleInCustom(RandFloat.GetMagnitude(magnitude), period);
        }
    }
}