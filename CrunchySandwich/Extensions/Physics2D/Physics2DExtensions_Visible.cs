using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public partial class Physics2DExtensions
    {
        static public IEnumerable<Collider2D> ObserveAll(Vector2 position, float radius, int layer_mask, int block_mask)
        {
            return OverlapCircleAll(position, radius, layer_mask)
                .Narrow(c => CanObserve(position, c.GetPlanarPosition(), block_mask));
        }

        static public bool CanObserve(Vector2 position, Vector2 target, int block_mask)
        {
            if (LinecastAll(position, target, block_mask).IsEmpty())
                return true;

            return false;
        }
    }
}