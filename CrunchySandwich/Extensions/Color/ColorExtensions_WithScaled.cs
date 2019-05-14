using System;
using UnityEngine;

namespace CrunchySandwich
{
    static public class ColorExtensions_WithScaled
    {
        static public Color GetWithScaledRed(this Color color, float s)
        {
            return new Color(color.r * s, color.g, color.b, color.a);
        }

        static public Color GetWithScaledGreen(this Color color, float s)
        {
            return new Color(color.r, color.g * s, color.b, color.a);
        }

        static public Color GetWithScaledBlue(this Color color, float s)
        {
            return new Color(color.r, color.g, color.b * s, color.a);
        }

        static public Color GetWithScaledAlpha(this Color color, float s)
        {
            return new Color(color.r, color.g, color.b, color.a * s);
        }
    }
}