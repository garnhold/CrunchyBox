using System;
using UnityEngine;

namespace CrunchySandwich
{
    static public class ColorExtensions_HSL
    {
        static public Color GetBrightened(this Color item, float scale)
        {
            return new Color(item.r * scale, item.g * scale, item.b * scale, item.a);
        }
    }
}