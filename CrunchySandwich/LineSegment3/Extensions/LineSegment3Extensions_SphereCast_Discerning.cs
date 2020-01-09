using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class LineSegment3Extensions_SphereCastDiscerning
    {
        static public bool SphereCastDiscerning(this LineSegment3 item, float radius, Predicate<RaycastHit> predicate, out RaycastHit hit, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().SphereCastDiscerning(radius, predicate, out hit, item.GetLength(), layer_mask);
        }

        static public bool SphereCastDiscerning(this LineSegment3 item, float radius, Predicate<RaycastHit> predicate, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().SphereCastDiscerning(radius, predicate, item.GetLength(), layer_mask);
        }

        static public RaycastHit SphereCastDiscerningGetHit(this LineSegment3 item, float radius, Predicate<RaycastHit> predicate, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().SphereCastDiscerningGetHit(radius, predicate, item.GetLength(), layer_mask);
        }
    }
}