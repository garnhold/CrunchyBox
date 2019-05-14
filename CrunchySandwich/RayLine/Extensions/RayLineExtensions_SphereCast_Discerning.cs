using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class RayLineExtensions_SphereCastDiscerning
    {
        static public bool SphereCastDiscerning(this RayLine item, float radius, Predicate<RaycastHit> predicate, out RaycastHit hit, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().SphereCastDiscerning(radius, predicate, out hit, item.GetLength(), layer_mask);
        }

        static public bool SphereCastDiscerning(this RayLine item, float radius, Predicate<RaycastHit> predicate, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().SphereCastDiscerning(radius, predicate, item.GetLength(), layer_mask);
        }

        static public RaycastHit SphereCastDiscerningGetHit(this RayLine item, float radius, Predicate<RaycastHit> predicate, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().SphereCastDiscerningGetHit(radius, predicate, item.GetLength(), layer_mask);
        }
    }
}