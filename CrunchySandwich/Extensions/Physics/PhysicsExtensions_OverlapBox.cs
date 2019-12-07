using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public partial class PhysicsExtensions
    {
        static public IEnumerable<Collider> OverlapBox(Bounds bounds, int layer_mask = IntBits.ALL_BITS)
        {
            return COLLIDER_POOL.UseEnumerateExpandForFuture(
                a => Physics.OverlapBoxNonAlloc(bounds.center, bounds.extents, a, Quaternion.identity, layer_mask)
            );
        }
    }
}