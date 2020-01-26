using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector2Extensions_Angle_Percent
    {
        static public Vector2 CreateDirection(float percent)
        {
            return new Vector2(TrigPercent.Cos(percent), TrigPercent.Sin(percent));
        }

        static public float GetAngleInPercent(this Vector2 item)
        {
            return TrigPercent.Atan2(item.y, item.x);
        }

        static public float GetAngleInPercentDifference(this Vector2 item, Vector2 other)
        {
            return item.GetAngleInPercent().GetPercentAngleDifference(other.GetAngleInPercent());
        }

        static public float GetAngleInPercentDistance(this Vector2 item, Vector2 other)
        {
            return item.GetAngleInPercent().GetPercentAngleDistance(other.GetAngleInPercent());
        }

        static public Vector2 GetAdjustDirectionAngleInPercent(this Vector2 item, float adjustment)
        {
            return CreateDirection(item.GetAngleInPercent() + adjustment);
        }

        static public Vector2 GetJitteredDirectionAngleInPercent(this Vector2 item, float magnitude)
        {
            return item.GetAdjustDirectionAngleInPercent(RandFloat.GetMagnitude(magnitude));
        }
    }
}