using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class SpriteRendererExtensions_Color_Get
    {
        static public float GetRed(this SpriteRenderer item)
        {
            return item.color.r;
        }

        static public float GetGreen(this SpriteRenderer item)
        {
            return item.color.g;
        }

        static public float GetBlue(this SpriteRenderer item)
        {
            return item.color.b;
        }

        static public float GetAlpha(this SpriteRenderer item)
        {
            return item.color.a;
        }
    }
}