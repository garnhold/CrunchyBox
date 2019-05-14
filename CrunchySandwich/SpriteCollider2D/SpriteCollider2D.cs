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
        private DateTime last_generate_complete_paths_time;

        private void GenerateCompletePaths(Grid<bool> solid_grid)
        {
            float units_per_cell = sprite.GetUnitsPerPixel();
            Vector2 unit_offset = sprite.pivot * units_per_cell;

            complete_paths = new List<List<Vector2>>(
                solid_grid.TraverseEdges(6).Convert(
                    p => p.Convert(c => new Vector2(c.GetX(), c.GetY()) * units_per_cell - unit_offset).ToList()
                )
            );

            last_generate_complete_paths_time = DateTime.UtcNow;
        }

        public void UpdateGeometry(DateTime last_source_write_time, Operation<Grid<bool>> operation)
        {
            float units_per_cell = sprite.GetUnitsPerPixel();
            PolygonCollider2D polygon_collider = GetComponent<PolygonCollider2D>();
            List<List<Vector2>> reduced_paths = new List<List<Vector2>>();

            if (last_source_write_time > last_generate_complete_paths_time || complete_paths.IsEmpty())
                GenerateCompletePaths(operation.Execute());

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

            polygon_collider.pathCount = reduced_paths.Count;
            reduced_paths.ProcessWithIndex((i, p) => polygon_collider.SetPath(i, p.ToArray()));
        }

        public void DirtyGeometry()
        {
            complete_paths = null;
            last_generate_complete_paths_time = DateTime.MinValue;
        }

        public void SetSpriteAutomatically()
        {
            sprite = GetComponent<SpriteRenderer>().IfNotNull(r => r.sprite);
            DirtyGeometry();
        }

        public Sprite GetSprite()
        {
            return sprite;
        }

        public float GetAlphaThreshold()
        {
            return alpha_threshold;
        }
    }
}