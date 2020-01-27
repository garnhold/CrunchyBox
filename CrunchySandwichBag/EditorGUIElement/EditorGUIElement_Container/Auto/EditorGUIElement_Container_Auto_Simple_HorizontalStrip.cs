using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    public class EditorGUIElement_Container_Auto_Simple_HorizontalStrip : EditorGUIElement_Container_Auto_Simple
    {
        private float child_width;

        protected override float DoPlanInternal()
        {
            child_width = GetContentsWidth() / GetChildren().Count();

            return GetChildren().Convert(e => e.Plan(child_width, GetLayoutState())).Max();
        }

        protected override void LayoutContentsInternal(Vector2 position)
        {
            foreach (EditorGUIElement element in GetChildren())
            {
                element.Layout(position);
                position.x += element.GetFootprintWidth();
            }
        }
    }
}