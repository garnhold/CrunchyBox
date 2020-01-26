using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector2Extensions_Angle_Degrees
    {
        static public Vector2 CreateDirection(float degrees)
        {
            return new Vector2(TrigDegree.Cos(degrees), TrigDegree.Sin(degrees));
        }

        static public float GetAngleInDegrees(this Vector2 item)
        {
            return TrigDegree.Atan2(item.y, item.x);
        }

        static public float GetAngleInDegreesDifference(this Vector2 item, Vector2 other)
        {
            return item.GetAngleInDegrees().GetDegreeAngleDifference(other.GetAngleInDegrees());
        }

        static public float GetAngleInDegreesDistance(this Vector2 item, Vector2 other)
        {
            return item.GetAngleInDegrees().GetDegreeAngleDistance(other.GetAngleInDegrees());
        }

        static public Vector2 GetAdjustDirectionAngleInDegrees(this Vector2 item, float adjustment)
        {
            return CreateDirection(item.GetAngleInDegrees() + adjustment);
        }

        static public Vector2 GetJitteredDirectionAngleInDegrees(this Vector2 item, float magnitude)
        {
            return item.GetAdjustDirectionAngleInDegrees(RandFloat.GetMagnitude(magnitude));
        }
    }
}