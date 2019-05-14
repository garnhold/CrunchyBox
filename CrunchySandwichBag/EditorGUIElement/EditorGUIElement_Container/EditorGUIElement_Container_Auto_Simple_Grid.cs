using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIElement_Container_Auto_Simple_Grid : EditorGUIElement_Container_Auto_Simple
    {
        private int width_in_cells;

        protected override void LayoutContentsInternal(Rect rect, float label_width)
        {
            Rect remaining_rect = rect;
            float cell_width = rect.width / width_in_cells;

            float y = rect.yMin;
            foreach (IEnumerable<EditorGUIElement> row in GetChildren().ChunkPermissive(width_in_cells))
            {
                float x = rect.xMin;
                foreach (EditorGUIElement element in row)
                {
                    element.Layout(new Rect(x, y, cell_width, element.GetHeight()), label_width);
                    x += cell_width;
                }

                y += row.Convert(e => e.GetHeight()).Max();
            }
        }

        protected override float CalculateElementHeightInternal()
        {
            return GetChildren().Convert(c => c.GetHeight()).ChunkPermissive(width_in_cells).Convert(r => r.Max()).Sum();
        }

        public EditorGUIElement_Container_Auto_Simple_Grid(int w)
        {
            width_in_cells = w;
        }
    }
}