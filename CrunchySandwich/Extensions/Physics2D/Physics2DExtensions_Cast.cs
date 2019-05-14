using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public partial class Physics2DExtensions
    {
        static public IEnumerable<RaycastHit2D> RaycastAll(Vector2 position, Vector2 direction, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            return RAYCAST_HIT_POOL.UseEnumerateExpand(delegate(RaycastHit2D[] hits) {
                return Physics2D.RaycastNonAlloc(position, direction, hits, max_distance, layer_mask);
            });
        }

        static public IEnumerable<RaycastHit2D> BoxCastAll(Vector2 position, Vector2 direction, Vector2 size, float angle, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            return RAYCAST_HIT_POOL.UseEnumerateExpand(delegate(RaycastHit2D[] hits) {
                return Physics2D.BoxCastNonAlloc(position, size, angle, direction, hits);
            });
        }
        static public IEnumerable<RaycastHit2D> BoxCastAll(Rect rect, Vector2 direction, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            return BoxCastAll(rect.GetCenterPoint(), direction, rect.GetSize(), 0.0f, max_distance, layer_mask);
        }

        static public IEnumerable<RaycastHit2D> CircleCastAll(Vector2 position, Vector2 direction, float radius, float max_distance = float.PositiveInfinity, int layer_mask = IntBits.ALL_BITS)
        {
            return RAYCAST_HIT_POOL.UseEnumerateExpand(delegate(RaycastHit2D[] hits) {
                return Physics2D.CircleCastNonAlloc(position, radius, direction, hits, max_distance, layer_mask);
            });
        }
    }
}