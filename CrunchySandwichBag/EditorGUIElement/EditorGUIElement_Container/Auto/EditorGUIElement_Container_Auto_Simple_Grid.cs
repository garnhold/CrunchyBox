using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    public class EditorGUIElement_Container_Auto_Simple_Grid : EditorGUIElement_Container_Auto_Simple
    {
        private int width_in_cells;

        protected override float DoPlanInternal()
        {
            float cell_width = GetContentsWidth() / width_in_cells;

            return GetChildren().Convert(c => c.Plan(cell_width, GetLayoutState()))
                    .ChunkPermissive(width_in_cells)
                    .Convert(r => r.Max())
                    .Sum();
        }

        protected override void LayoutContentsInternal(Vector2 position)
        {
            float y = position.x;
            foreach (IEnumerable<EditorGUIElement> row in GetChildren().ChunkPermissive(width_in_cells))
            {
                float x = position.y;
                foreach (EditorGUIElement element in row)
                {
                    element.Layout(new Vector2(x, y));
                    x += element.GetFootprintWidth();
                }

                y += row.Convert(e => e.GetFootprintHeight()).Max();
            }
        }

        public EditorGUIElement_Container_Auto_Simple_Grid(int w)
        {
            width_in_cells = w;
        }
    }
}