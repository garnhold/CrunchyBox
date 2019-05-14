using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class RayExtensions_Cast_Discerning
    {
        static public RaycastHit CastDiscerningGetHit(this Ray item, Predicate<RaycastHit> predicate, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            return Physics.RaycastAll(item, max_distance, layer_mask)
                .Narrow(h => h.DidHit())
                .Narrow(predicate)
                .FindLowestRated(h => h.distance);
        }

        static public bool CastDiscerning(this Ray item, Predicate<RaycastHit> predicate, out RaycastHit hit, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            hit = item.CastDiscerningGetHit(predicate, max_distance, layer_mask);
            return hit.DidHit();
        }

        static public bool CastDiscerning(this Ray item, Predicate<RaycastHit> predicate, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            RaycastHit hit;
            return item.CastDiscerning(predicate, out hit, max_distance, layer_mask);
        }

        
    }
}