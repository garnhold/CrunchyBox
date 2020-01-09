using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class RayExtensions_Cast
    {
        static public bool Cast(this Ray item, out RaycastHit hit, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            return Physics.Raycast(item, out hit, max_distance, layer_mask);
        }

        static public bool Cast(this Ray item, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            return Physics.Raycast(item, max_distance, layer_mask);
        }

        static public RaycastHit CastGetHit(this Ray item, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            RaycastHit hit;

            item.Cast(out hit, max_distance, layer_mask);
            return hit;
        }
    }
}