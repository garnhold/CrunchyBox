using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class LineSegment3Extensions_SphereCastAgainst
    {
        static public bool SphereCastAgainstComplyingDirection(this LineSegment3 item, float radius, out RaycastHit hit, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().SphereCastAgainstComplyingDirection(radius, out hit, item.GetLength(), layer_mask);
        }

        static public bool SphereCastAgainstOpposingDirection(this LineSegment3 item, float radius, out RaycastHit hit, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().SphereCastAgainstOpposingDirection(radius, out hit, item.GetLength(), layer_mask);
        }
    }
}