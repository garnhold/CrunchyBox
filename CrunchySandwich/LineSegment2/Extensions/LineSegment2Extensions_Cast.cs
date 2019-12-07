using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class LineSegment2Extensions_Cast
    {
        static public bool Cast(this LineSegment2 item, out RaycastHit2D hit, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().Cast(out hit, item.GetLength(), layer_mask);
        }

        static public bool Cast(this LineSegment2 item, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().Cast(item.GetLength(), layer_mask);
        }

        static public RaycastHit2D CastGetHit(this LineSegment2 item, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().CastGetHit(item.GetLength(), layer_mask);
        }

        static public IEnumerable<RaycastHit2D> CastGetAllHits(this LineSegment2 item, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().CastGetAllHits(item.GetLength(), layer_mask);
        }
    }
}