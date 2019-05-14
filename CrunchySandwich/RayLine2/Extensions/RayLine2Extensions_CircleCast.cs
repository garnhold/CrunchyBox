using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class RayLine2Extensions_CircleCast
    {
        static public bool CircleCast(this RayLine2 item, float radius, out RaycastHit2D hit, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().CircleCast(radius, out hit, item.GetLength(), layer_mask);
        }

        static public bool CircleCast(this RayLine2 item, float radius, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().CircleCast(radius, item.GetLength(), layer_mask);
        }

        static public RaycastHit2D CircleCastGetHit(this RayLine2 item, float radius, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().CircleCastGetHit(radius, item.GetLength(), layer_mask);
        }

        static public IEnumerable<RaycastHit2D> CircleCastGetAllHits(this RayLine2 item, float radius, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().CircleCastGetAllHits(radius, item.GetLength(), layer_mask);
        }
    }
}