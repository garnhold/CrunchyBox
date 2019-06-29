using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AssetClassCategory("Sprite")]
    public class SpriteVectorizer : CustomAsset
    {
        [SerializeField]private float alpha_threshold = 0.9f;
        [SerializeField]private float pre_scale = 1.0f;
        [SerializeField]private int maximum_trace_gap = 6;

        [SerializeField]private float inflate_amount = 1.0f;

        [SerializeField]private int quality = 50;
        [SerializeField]private float maximum_normal_deviance = 5.0f;

        [SerializeField]private float minimum_inter_length = 1.0f;
        [SerializeField]private float minimum_triangle_area = 0.003f;

        [SerializeField]private Sprite test_sprite;
        [SerializeField]private float test_line_thickness = 1.0f;
        [SerializeField]private float test_point_size = 0.0f;

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

        public Sprite GetTestSprite()
        {
            return test_sprite;
        }

        public float GetTestLineThickness()
        {
            return test_line_thickness;
        }

        public float GetTestPointSize()
        {
            return test_point_size;
        }
    }
}