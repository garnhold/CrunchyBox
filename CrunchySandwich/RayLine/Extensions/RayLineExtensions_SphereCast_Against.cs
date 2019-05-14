using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class RayLineExtensions_SphereCastAgainst
    {
        static public bool SphereCastAgainstComplyingDirection(this RayLine item, float radius, out RaycastHit hit, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().SphereCastAgainstComplyingDirection(radius, out hit, item.GetLength(), layer_mask);
        }

        static public bool SphereCastAgainstOpposingDirection(this RayLine item, float radius, out RaycastHit hit, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().SphereCastAgainstOpposingDirection(radius, out hit, item.GetLength(), layer_mask);
        }
    }
}