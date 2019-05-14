using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class RayLineExtensions_Cast
    {
        static public bool Cast(this RayLine item, out RaycastHit hit, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().Cast(out hit, item.GetLength(), layer_mask);
        }

        static public bool Cast(this RayLine item, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().Cast(item.GetLength(), layer_mask);
        }

        static public RaycastHit CastGetHit(this RayLine item, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().CastGetHit(item.GetLength(), layer_mask);
        }
    }
}