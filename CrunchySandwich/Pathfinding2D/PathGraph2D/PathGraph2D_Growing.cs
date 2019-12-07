using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [AddComponentMenu("Pathfinding2D/PathGraph2D/PathGraph2D_Growing")]
    public class PathGraph2D_Growing : PathGraph2D
    {
        [SerializeField]private int max_number_nodes = 250;
        [SerializeField]private int max_number_branches = 10;
        [SerializeField]private float minimum_radius = 0.6f;
        [SerializeField]private float radius_bleed = 0.1f;

        [AttachEditGadget("WorldPoint")][SerializeField]private Vector2 origin;

        private Rect rect;
        private List<Vector2> directions;
        private Queue<PathNode2D> active_nodes;

        private void Seed(Vector2 position, float radius)
        {
            if (radius >= minimum_radius)
            {
                if (GetNumberGraphNodes() < max_number_nodes)
                {
                    if (rect.Contains(position))
                        active_nodes.Enqueue(AddPathNode(position, radius + radius_bleed));
                }
            }
        }

        private void GrowPathNode(PathNode2D node)
        {
            Vector2 position = node.GetPlanarPosition();
            float radius = node.GetRadius() + 0.01f;

            foreach (Vector2 direction in directions)
            {
                Vector2 edge_position = position + direction * radius;
                float new_radius = Pathfinding2D.GetInstance().GetPotentialFixedEdgeClearingRadius(edge_position, direction, true);

                Seed(edge_position + direction * new_radius, new_radius);
            }
        }

        protected override void GenerateInternal(Rect r)
        {
            rect = r;

            directions = directions = Vector2s.RadialFromDegrees(
                Floats.Line(0.0f, 360.0f, max_number_branches, false)
            ).ToList();

            active_nodes = new Queue<PathNode2D>();
            Seed(origin, Pathfinding2D.GetInstance().GetPotentialClearingRadius(origin));

            while (active_nodes.IsNotEmpty())
                GrowPathNode(active_nodes.Dequeue());
        }
    }
}