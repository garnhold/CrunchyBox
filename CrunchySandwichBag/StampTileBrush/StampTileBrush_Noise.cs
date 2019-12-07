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
    public class StampTileBrush_Noise : StampTileBrush
    {
        [SerializeField][Range(0, 10)]private int radius = 2;
        [SerializeField][Range(0.0f, 1.0f)]private float hardness = 0.8f;

        protected override IEnumerable<Vector2Int> GetPoints()
        {
            for (int dy = -radius; dy <= radius; dy++)
            {
                for (int dx = -radius; dx <= radius; dx++)
                {
                    Vector2Int point = new Vector2Int(dx, dy);

                    if (point.GetHashCode().GetACongruent().GetFloatPercent().GetAbs() >= hardness)
                        yield return point;
                }
            }
        }
    }
}