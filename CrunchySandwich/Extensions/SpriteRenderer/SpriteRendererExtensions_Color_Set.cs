using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class SpriteRendererExtensions_Color_Set
    {
        static public void SetRed(this SpriteRenderer item, float red)
        {
            item.color = item.color.GetWithRed(red);
        }

        static public void SetGreen(this SpriteRenderer item, float green)
        {
            item.color = item.color.GetWithGreen(green);
        }

        static public void SetBlue(this SpriteRenderer item, float blue)
        {
            item.color = item.color.GetWithBlue(blue);
        }

        static public void SetAlpha(this SpriteRenderer item, float alpha)
        {
            item.color = item.color.GetWithAlpha(alpha);
        }
    }
}