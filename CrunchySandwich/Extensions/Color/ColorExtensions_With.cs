using System;
using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class ColorExtensions_With
    {
        static public Color GetWithRed(this Color color, float r)
        {
            return new Color(r, color.g, color.b, color.a);
        }

        static public Color GetWithGreen(this Color color, float g)
        {
            return new Color(color.r, g, color.b, color.a);
        }

        static public Color GetWithBlue(this Color color, float b)
        {
            return new Color(color.r, color.g, b, color.a);
        }

        static public Color GetWithRGB(this Color color, float r, float g, float b)
        {
            return new Color(r, g, b, color.a);
        }
        static public Color GetWithRGB(this Color color, Color rgb)
        {
            return color.GetWithRGB(rgb.r, rgb.g, rgb.b);
        }

        static public Color GetWithAlpha(this Color color, float a)
        {
            return new Color(color.r, color.g, color.b, a);
        }
    }
}