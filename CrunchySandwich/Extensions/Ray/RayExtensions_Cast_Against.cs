using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class RayExtensions_Cast_Against
    {
        static public bool CastAgainstComplyingDirection(this Ray item, out RaycastHit hit, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            return item.CastDiscerning(h => h.normal.IsComplyingDirection(item.direction), out hit, max_distance, layer_mask);
        }

        static public bool CastAgainstOpposingDirection(this Ray item, out RaycastHit hit, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            return item.CastDiscerning(h => h.normal.IsOpposingDirection(item.direction), out hit, max_distance, layer_mask);
        }
    }
}