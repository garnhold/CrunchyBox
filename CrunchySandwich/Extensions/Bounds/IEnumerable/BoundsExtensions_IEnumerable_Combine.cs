using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class BoundsExtensions_IEnumerable_Combine
    {
        static public IEnumerable<Bounds> Combine(this IEnumerable<Bounds> item, float tolerance_percent)
        {
            return item.Squish(delegate(Bounds bound1, Bounds bound2, out Bounds combined) {
                return bound1.TryCombine(bound2, tolerance_percent, out combined);
            });
        }
    }
}