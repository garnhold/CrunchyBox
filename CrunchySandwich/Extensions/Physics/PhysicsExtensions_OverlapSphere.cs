using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public partial class PhysicsExtensions
    {
        static public IEnumerable<Collider> OverlapSphere(Vector3 position, float radius, int layer_mask = IntBits.ALL_BITS)
        {
            return COLLIDER_POOL.UseEnumerateExpandForFuture(
                a => Physics.OverlapSphereNonAlloc(position, radius, a, layer_mask)
            );
        }
    }
}