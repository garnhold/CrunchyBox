using System;
using UnityEngine;

namespace CrunchySandwich
{
    static public class ColorExtensions_Grayscale
    {
        static public float GetGrayscale(this Color item)
        {
            return (item.r + item.g + item.b) / 3.0f;
        }
    }
}