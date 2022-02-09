using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [AddComponentMenu("Pathfinding2D/PathGraph2D/PathGraph2D_QuadTree")]
    public class PathGraph2D_QuadTree : PathGraph2D
    {
        [SerializeField]private int max_depth = 5;
        [SerializeField]private float minimum_radius = 0.6f;
        [SerializeField]private float target_utilization = 0.5f;

        private void GenerateQuadTree(Rect rect, int depth)
        {
            Vector2 position = rect.GetCenterPoint();
            float maximum_radius = rect.GetSize().GetComponentsMax();

            float acceptable_radius = maximum_radius * target_utilization;
            float radius = Pathfinding2D.GetInstance().GetPotentialClearingRadius(position).BindBelow(maximum_radius * 2.0f);

            if (radius < acceptable_radius && depth < max_depth)
                rect.SplitIntoQuarters().Process(r => GenerateQuadTree(r, depth + 1));
            else
            {
                if (radius >= minimum_radius)
                    AddPathNode(position, radius);
            }
        }

        protected override void GenerateInternal(Rect rect)
        {
            GenerateQuadTree(rect, 0);
        }
    }
}