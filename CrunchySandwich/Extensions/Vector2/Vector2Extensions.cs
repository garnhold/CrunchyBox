using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions
    {
        static public Vector2 CreateDirectionFromRadians(float radians)
        {
            return Vector2Extensions_Angle_Radians.CreateDirection(radians);
        }

        static public Vector2 CreateDirectionFromDegrees(float degrees)
        {
            return Vector2Extensions_Angle_Degrees.CreateDirection(degrees);
        }

        static public Vector2 CreateDirectionFromPercent(float percent)
        {
            return Vector2Extensions_Angle_Percent.CreateDirection(percent);
        }
    }
}