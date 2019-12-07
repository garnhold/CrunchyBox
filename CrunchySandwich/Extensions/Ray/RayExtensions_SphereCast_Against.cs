using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class RayExtensions_SphereCast_Against
    {
        static public bool SphereCastAgainstComplyingDirection(this Ray item, float radius, out RaycastHit hit, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            return item.SphereCastDiscerning(radius, h => h.normal.IsComplyingDirection(item.direction), out hit, max_distance, layer_mask);
        }

        static public bool SphereCastAgainstOpposingDirection(this Ray item, float radius, out RaycastHit hit, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            return item.SphereCastDiscerning(radius, h => h.normal.IsOpposingDirection(item.direction), out hit, max_distance, layer_mask);
        }
    }
}