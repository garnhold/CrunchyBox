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
    public class EditorGUIElement_Container_Auto_Simple_HorizontalStrip : EditorGUIElement_Container_Auto_Simple
    {
        protected override void LayoutContentsInternal(Rect rect, float label_width)
        {
            Rect remaining_rect = rect;
            float child_width = rect.width / GetChildren().Count();

            foreach (EditorGUIElement element in GetChildren())
            {
                Rect current_rect;

                remaining_rect.SplitByXLeftOffset(child_width, out current_rect, out remaining_rect);
                element.Layout(current_rect, label_width);
            }
        }

        protected override float CalculateElementHeightInternal()
        {
            return GetChildren().Convert(e => e.GetHeight()).Max();
        }
    }
}