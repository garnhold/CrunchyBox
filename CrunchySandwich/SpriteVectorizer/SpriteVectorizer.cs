using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class SpriteVectorizer : Subsystem<SpriteVectorizer>
    {
        [SerializeField]private float alpha_threshold = 0.9f;
        [SerializeField]private float pre_scale = 1.0f;
        [SerializeField]private int maximum_trace_gap = 6;

        [SerializeField]private float maximum_sweep_normal_deviance = 5.0f;

        [SerializeField]private int inspect_length = 10;
        [SerializeField]private float maximum_inspect_normal_deviance = 1.0f;

        [SerializeField]private float minimum_inter_length = 2.0f;
        [SerializeField]private float minimum_shortest_to_longest_ratio = 0.003f;

        [SerializeField]private float inflate_amount = 1.0f;

        public IEnumerable<List<Vector2>> VectorizeSprite(Sprite sprite)
        {
            return sprite.UnscaledVectorize(alpha_threshold, maximum_trace_gap, pre_scale)
                .Convert(l => l.ApproximateLoop(
                    maximum_sweep_normal_deviance,
                    inspect_length,
                    maximum_inspect_normal_deviance,
                    minimum_inter_length,
                    minimum_shortest_to_longest_ratio
                ).OffsetInflateLoop(inflate_amount).Constrain(RectExtensions.CreateMinMaxRect(0.0f, 0.0f, sp)).ToList());

            constrain this tjo //the sprite rect so that over inflating and constraining gets perfect edges etc.
        }
        static public IEnumerable<List<Vector2>> Vectorize(Sprite sprite)
        {
            return GetInstance().VectorizeSprite(sprite);
        }
    }
}