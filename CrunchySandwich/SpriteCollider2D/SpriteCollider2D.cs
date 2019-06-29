using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [ExecuteInEditMode]
    [RequireComponent(typeof(PolygonCollider2D))]
    [AddComponentMenu("Physics 2D/Sprite Collider 2D")]
    public class SpriteCollider2D : MonoBehaviour
    {
        [SerializeField]private Sprite sprite;

        [SerializeField]private float alpha_threshold = 0.9f;
        [SerializeField]private float bisection_deviance = 1.0f;
        [SerializeField]private float sweep_deviance = 4.0f;
        [SerializeField]private float minimum_length = 5.0f;
        [SerializeField]private float minimum_shortest_to_longest_ratio = 0.003f;

        private List<List<Vector2>> complete_paths;
        private int last_generate_complete_paths_content_identity;
        private float last_generate_complete_paths_alpha_threshold;

        [ContextMenu("Set Sprite Automatically")]
        public void SetSpriteAutomatically()
        {
            sprite = GetComponent<SpriteRenderer>().IfNotNull(r => r.sprite);
        }

        private void OnValidate()
        {
            UpdateGeometry();
        }

        private void UpdateCompletePaths()
        {
            int content_identity = sprite.GetContentIdentity();

            if (complete_paths.IsEmpty() ||
                content_identity != last_generate_complete_paths_content_identity ||
                alpha_threshold != last_generate_complete_paths_alpha_threshold)
            {
                complete_paths = sprite.ScaledVectorize(alpha_threshold, 6, 1.0f).ToList();

                last_generate_complete_paths_content_identity = content_identity;
                last_generate_complete_paths_alpha_threshold = alpha_threshold;
            }
        }

        public void UpdateGeometry()
        {
            UpdateCompletePaths();

            GetComponent<PolygonCollider2D>().SetPaths(
                complete_paths.Convert(p => p
                    .BisectApproximateLoop(bisection_deviance * sprite.GetUnitsPerPixel())
                    .VariableSweepApproximateLoop(50, sweep_deviance * sprite.GetUnitsPerPixel())
                    .CollapseLoopPoints(minimum_length * sprite.GetUnitsPerPixel())
                    .CollapseLoopStellations(minimum_shortest_to_longest_ratio)
                    .ToList()
                )
                .Narrow(z => z.Count.IsBoundBetween(3, 256))
            );
        }
    }
}