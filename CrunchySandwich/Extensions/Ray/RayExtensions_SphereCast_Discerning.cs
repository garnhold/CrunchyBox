using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class RayExtensions_SphereCast_Discerning
    {
        static public RaycastHit SphereCastDiscerningGetHit(this Ray item, float radius, Predicate<RaycastHit> predicate, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            return Physics.SphereCastAll(item, radius, max_distance, layer_mask)
                .Narrow(h => h.DidHit())
                .Narrow(predicate)
                .FindLowestRated(h => h.distance);
        }

        static public bool SphereCastDiscerning(this Ray item, float radius, Predicate<RaycastHit> predicate, out RaycastHit hit, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            hit = item.SphereCastDiscerningGetHit(radius, predicate, max_distance, layer_mask);
            return hit.DidHit();
        }

        static public bool SphereCastDiscerning(this Ray item, float radius, Predicate<RaycastHit> predicate, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            RaycastHit hit;
            return item.SphereCastDiscerning(radius, predicate, out hit, max_distance, layer_mask);
        }
    }
}