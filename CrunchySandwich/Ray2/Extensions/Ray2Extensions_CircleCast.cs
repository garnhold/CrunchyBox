using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Ray2Extensions_CircleCast
    {
        static public bool CircleCast(this Ray2 item, float radius, out RaycastHit2D hit, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            hit = Physics2D.CircleCast(item.origin, radius, item.direction, max_distance, layer_mask);
            if (hit.DidHit())
                return true;

            return false;
        }

        static public bool CircleCast(this Ray2 item, float radius, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            RaycastHit2D hit;

            return item.CircleCast(radius, out hit, max_distance, layer_mask);
        }

        static public RaycastHit2D CircleCastGetHit(this Ray2 item, float radius, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            return Physics2D.CircleCast(item.origin, radius, item.direction, max_distance, layer_mask);
        }

        static public IEnumerable<RaycastHit2D> CircleCastGetAllHits(this Ray2 item, float radius, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            return Physics2DExtensions.CircleCastAll(item.origin, item.direction, radius, max_distance, layer_mask);
        }
    }
}