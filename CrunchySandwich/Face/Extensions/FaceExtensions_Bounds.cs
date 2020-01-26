using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class FaceExtensions_Bounds
    {
        static public Bounds GetBounds(this Face item)
        {
            return BoundsExtensions.CreateMinMaxBounds(item.v0, item.v1);
        }
    }
}