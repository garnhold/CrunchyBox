using System;
using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class ColorExtensions_Interpolate
    {
        static public Color GetInterpolate(this Color item, Color target, float amount)
        {
            amount = amount.BindBetween(0.0f, 1.0f);

            return item * (1.0f - amount) + target * amount;
        }
    }
}