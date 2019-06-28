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

        [SerializeField]private float inflate_amount = 1.0f;

        [SerializeField]private int quality = 50;
        [SerializeField]private float maximum_normal_deviance = 5.0f;

        [SerializeField]private float minimum_inter_length = 1.0f;
        [SerializeField]private float minimum_triangle_area = 0.003f;

        [SerializeField]private SpriteVectorizerTuner tuner;

        public IEnumerable<List<Vector2>> VectorizeSprite(Sprite sprite)
        {
            Rect binding_rect = sprite.GetSpriteSpaceRect();

            return sprite.UnscaledVectorize(alpha_threshold, maximum_trace_gap, pre_scale)
                .Convert(l => l
                    .InflateLoop(inflate_amount)
                    .Convert(p => p.BindWithin(binding_rect))
                    .ApproximateLoop(
                        quality,
                        maximum_normal_deviance,
                        minimum_inter_length,
                        minimum_triangle_area
                    )
                    .ToList()
                );
        }
        static public IEnumerable<List<Vector2>> Vectorize(Sprite sprite)
        {
            return GetInstance().VectorizeSprite(sprite);
        }
    }
}