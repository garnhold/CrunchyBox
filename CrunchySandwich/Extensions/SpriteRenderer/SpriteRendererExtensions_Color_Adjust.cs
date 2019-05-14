using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class SpriteRendererExtensions_Color_Adjust
    {
        static public void AdjustRed(this SpriteRenderer item, float amount)
        {
            item.SetRed(item.GetRed() + amount);
        }

        static public void AdjustGreen(this SpriteRenderer item, float amount)
        {
            item.SetGreen(item.GetGreen() + amount);
        }

        static public void AdjustBlue(this SpriteRenderer item, float amount)
        {
            item.SetGreen(item.GetGreen() + amount);
        }

        static public void AdjustAlpha(this SpriteRenderer item, float amount)
        {
            item.SetAlpha(item.GetAlpha() + amount);
        }
    }
}