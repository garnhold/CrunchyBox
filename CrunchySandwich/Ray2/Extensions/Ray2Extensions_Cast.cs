using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Ray2Extensions_Cast
    {
        static public bool Cast(this Ray2 item, out RaycastHit2D hit, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            hit = item.CastGetHit(max_distance, layer_mask);
            if (hit.DidHit())
                return true;

            return false;
        }

        static public bool Cast(this Ray2 item, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            RaycastHit2D hit;

            return item.Cast(out hit, max_distance, layer_mask);
        }

        static public RaycastHit2D CastGetHit(this Ray2 item, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            return Physics2D.Raycast(item.origin, item.direction, max_distance, layer_mask);
        }

        static public IEnumerable<RaycastHit2D> CastGetAllHits(this Ray2 item, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            return Physics2DExtensions.RaycastAll(item.origin, item.direction, max_distance, layer_mask);
        }
    }
}