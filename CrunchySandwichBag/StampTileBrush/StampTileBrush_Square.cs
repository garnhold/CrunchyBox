using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    [CustomGridBrush]
    public class StampTileBrush_Square : StampTileBrush
    {
        [SerializeField][Range(0, 10)]private int radius = 2;

        protected override IEnumerable<Vector2Int> GetPoints()
        {
            for (int dy = -radius; dy <= radius; dy++)
            {
                for (int dx = -radius; dx <= radius; dx++)
                    yield return new Vector2Int(dx, dy);
            }
        }
    }
}