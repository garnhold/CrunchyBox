using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class LineSegment3Extensions_Cast_Discerning
    {
        static public bool CastDiscerning(this LineSegment3 item, Predicate<RaycastHit> predicate, out RaycastHit hit, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().CastDiscerning(predicate, out hit, item.GetLength(), layer_mask);
        }

        static public bool CastDiscerning(this LineSegment3 item, Predicate<RaycastHit> predicate, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().CastDiscerning(predicate, item.GetLength(), layer_mask);
        }

        static public RaycastHit CastDiscerningGetHit(this LineSegment3 item, Predicate<RaycastHit> predicate, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().CastDiscerningGetHit(predicate, item.GetLength(), layer_mask);
        }
    }
}