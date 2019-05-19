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
        
        [SerializeField]private bool is_show_all_parameters = false;

        [SerializeField]private float alpha_threshold = 0.9f;
        [SerializeField]private float bisection_deviance = 1.0f;
        [SerializeField]private float sweep_deviance = 4.0f;
        [SerializeField]private float minimum_length = 5.0f;
        [SerializeField]private float minimum_shortest_to_longest_ratio = 0.003f;

        private List<List<Vector2>> complete_paths;
        private int last_generate_complete_paths_content_identity;
        private float last_generate_complete_paths_alpha_threshold;

        private void UpdateCompletePaths()
        {
            int content_identity = sprite.GetContentIdentity();

            if (complete_paths.IsEmpty() ||
                content_identity != last_generate_complete_paths_content_identity ||
                alpha_threshold != last_generate_complete_paths_alpha_threshold)
            {
                complete_paths = sprite.Vectorize(alpha_threshold, 6).ToList();

                last_generate_complete_paths_content_identity = content_identity;
                last_generate_complete_paths_alpha_threshold = alpha_threshold;
            }
        }

        public void UpdateGeometry()
        {
            float units_per_cell = sprite.GetUnitsPerPixel();
            List<List<Vector2>> reduced_paths = new List<List<Vector2>>();

            UpdateCompletePaths();

            foreach (List<Vector2> path in complete_paths)
            {
                List<Vector2> reduced_path = path.ToList();

                reduced_path = reduced_path.BisectApproximateLoop(bisection_deviance * units_per_cell).ToList();
                reduced_path = reduced_path.VariableSweepApproximateLoop(50, sweep_deviance * units_per_cell).ToList();
                reduced_path = reduced_path.CollapseLoopPoints(minimum_length * units_per_cell).ToList();
                reduced_path = reduced_path.CollapseLoopStellations(minimum_shortest_to_longest_ratio).ToList();

                if (reduced_path.Count >= 3 && reduced_path.Count < 256)
                    reduced_paths.Add(reduced_path);
            }

            GetComponent<PolygonCollider2D>().SetPaths(reduced_paths);
        }

        public void SetSpriteAutomatically()
        {
            sprite = GetComponent<SpriteRenderer>().IfNotNull(r => r.sprite);
        }
    }
}