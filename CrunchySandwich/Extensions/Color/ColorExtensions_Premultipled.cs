using System;
using UnityEngine;

namespace CrunchySandwich
{
    static public class ColorExtensions_Premultipled
    {
        static public Color ConvertStraightToPremultiplied(this Color item)
        {
            return new Color(item.r * item.a, item.g * item.a, item.b * item.a, item.a);
        }

        static public Color ConvertPremultipliedToStraight(this Color item)
        {
            return new Color(item.r / item.a, item.g / item.a, item.b / item.a, item.a);
        }
    }
}