using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class RayExtensions_SphereCast
    {
        static public bool SphereCast(this Ray item, float radius, out RaycastHit hit, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            return Physics.SphereCast(item, radius, out hit, max_distance, layer_mask);
        }

        static public bool SphereCast(this Ray item, float radius, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            return Physics.SphereCast(item, radius, max_distance, layer_mask);
        }

        static public RaycastHit SphereCastGetHit(this Ray item, float radius, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            RaycastHit hit;

            item.SphereCast(radius, out hit, max_distance, layer_mask);
            return hit;
        }
    }
}