using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class LineSegment2Extensions_CircleCast
    {
        static public bool CircleCast(this LineSegment2 item, float radius, out RaycastHit2D hit, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().CircleCast(radius, out hit, item.GetLength(), layer_mask);
        }

        static public bool CircleCast(this LineSegment2 item, float radius, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().CircleCast(radius, item.GetLength(), layer_mask);
        }

        static public RaycastHit2D CircleCastGetHit(this LineSegment2 item, float radius, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().CircleCastGetHit(radius, item.GetLength(), layer_mask);
        }

        static public IEnumerable<RaycastHit2D> CircleCastGetAllHits(this LineSegment2 item, float radius, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().CircleCastGetAllHits(radius, item.GetLength(), layer_mask);
        }
    }
}