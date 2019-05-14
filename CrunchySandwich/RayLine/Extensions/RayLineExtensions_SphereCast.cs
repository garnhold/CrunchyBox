using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class RayLineExtensions_SphereCast
    {
        static public bool SphereCast(this RayLine item, float radius, out RaycastHit hit, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().SphereCast(radius, out hit, item.GetLength(), layer_mask);
        }

        static public bool SphereCast(this RayLine item, float radius, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().SphereCast(radius, item.GetLength(), layer_mask);
        }

        static public RaycastHit SphereCastGetHit(this RayLine item, float radius, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().SphereCastGetHit(radius, item.GetLength(), layer_mask);
        }
    }
}