using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class BoundsExtensions_Combine
    {
        static public bool TryCombine(this Bounds item, Bounds bounds, float tolerance_percent, out Bounds combined)
        {
            combined = item.GetEncompassing(bounds);

            if (combined.GetVolume() * tolerance_percent <= item.GetVolume() + bounds.GetVolume())
                return true;

            return false;
        }
    }
}