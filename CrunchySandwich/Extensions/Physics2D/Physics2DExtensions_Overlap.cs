using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public partial class Physics2DExtensions
    {
        static public IEnumerable<Collider2D> OverlapCircleAll(Vector2 position, float radius, int layer_mask = IntBits.ALL_BITS)
        {
            return COLLIDER_POOL.UseEnumerateExpand(
                a => Physics2D.OverlapCircleNonAlloc(position, radius, a, layer_mask)
            );
        }

        static public IEnumerable<Collider2D> OverlapBoxAll(Vector2 position, Vector2 size, float angle, int layer_mask = IntBits.ALL_BITS)
        {
            return COLLIDER_POOL.UseEnumerateExpand(
                a => Physics2D.OverlapBoxNonAlloc(position, size, angle, a, layer_mask)
            );
        }
        static public IEnumerable<Collider2D> OverlapBoxAll(Rect rect, int layer_mask = IntBits.ALL_BITS)
        {
            return OverlapBoxAll(rect.GetCenterPoint(), rect.GetSize(), 0.0f, layer_mask);
        }

        static public IEnumerable<Collider2D> OverlapColliderAll(Collider2D collider, int layer_mask = IntBits.ALL_BITS)
        {
            ContactFilter2D filter = new ContactFilter2D();

            filter.useTriggers = true;
            filter.useLayerMask = true;
            filter.layerMask = layer_mask;

            return COLLIDER_POOL.UseEnumerateExpand(
                a => Physics2D.OverlapCollider(collider, filter, a)
            );
        }
    }
}