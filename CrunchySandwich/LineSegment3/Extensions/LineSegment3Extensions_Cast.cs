using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class LineSegment3Extensions_Cast
    {
        static public bool Cast(this LineSegment3 item, out RaycastHit hit, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().Cast(out hit, item.GetLength(), layer_mask);
        }

        static public bool Cast(this LineSegment3 item, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().Cast(item.GetLength(), layer_mask);
        }

        static public RaycastHit CastGetHit(this LineSegment3 item, int layer_mask = IntBits.ALL_BITS)
        {
            return item.GetRay().CastGetHit(item.GetLength(), layer_mask);
        }
    }
}