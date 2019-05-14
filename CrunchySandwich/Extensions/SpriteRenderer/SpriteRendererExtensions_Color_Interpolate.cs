using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class SpriteRendererExtensions_Color_Interpolate
    {
        static public void InterpolateRed(this SpriteRenderer item, float target, float amount)
        {
            item.SetRed(item.GetRed().GetInterpolate(target, amount));
        }

        static public void InterpolateGreen(this SpriteRenderer item, float target, float amount)
        {
            item.SetGreen(item.GetGreen().GetInterpolate(target, amount));
        }

        static public void InterpolateBlue(this SpriteRenderer item, float target, float amount)
        {
            item.SetBlue(item.GetBlue().GetInterpolate(target, amount));
        }

        static public void InterpolateAlpha(this SpriteRenderer item, float target, float amount)
        {
            item.SetAlpha(item.GetAlpha().GetInterpolate(target, amount));
        }
    }
}