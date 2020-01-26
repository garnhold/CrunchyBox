using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class ColorExtensions_Towards
    {
        static public Color GetTowards(this Color item, Color target, Color amount)
        {
            return new Color(
                item.r.GetTowards(target.r, amount.r),
                item.g.GetTowards(target.g, amount.g),
                item.b.GetTowards(target.b, amount.b),
                item.a.GetTowards(target.a, amount.a)
            );
        }
    }
}