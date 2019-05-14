using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_BindMagnitude
    {
        static public Vector2 BindMagnitudeAbove(this Vector2 item, float lower)
        {
            float magnitude;

            return item.GetNormalized(out magnitude) * magnitude.BindAbove(lower);
        }

        static public Vector2 BindMagnitudeBelow(this Vector2 item, float upper)
        {
            float magnitude;

            return item.GetNormalized(out magnitude) * magnitude.BindBelow(upper);
        }

        static public Vector2 BindMagnitudeBetween(this Vector2 item, float value1, float value2)
        {
            float magnitude;

            return item.GetNormalized(out magnitude) * magnitude.BindBetween(value1, value2);
        }
    }
}