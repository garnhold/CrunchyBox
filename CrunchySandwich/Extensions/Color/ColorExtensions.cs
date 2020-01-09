using System;
using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class ColorExtensions
    {
        static public Color CreateGrayscale(float g, float a)
        {
            return new Color(g, g, g, a);
        }
        static public Color CreateGrayscale(float g)
        {
            return CreateGrayscale(g, 1.0f);
        }
    }
}