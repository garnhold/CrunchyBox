using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    public class EditorGUIView
    {
        private Rect visible_rect;
        private EditorGUIElement element;

        public EditorGUIView(EditorGUIElement e)
        {
            element = e;
        }

        public void LayoutDrawUnwind(Rect rect, EditorGUILayoutState state)
        {
            if (state.ShouldUseVisibility())
            {
                Rect new_visible_rect = GUIUtilityExtensions.GetVisibleRect();

                if (new_visible_rect.height <= Screen.height && new_visible_rect.height >= 16.0f)
                    visible_rect = new_visible_rect;
            }
            else
            {
                visible_rect = rect;
            }

            if (rect.width > 16.0f)
            {
                element.Plan(rect.width, state);
                element.Layout(rect.min);

                element.Draw(visible_rect);
                element.Unwind();
            }
        }

        public void LayoutDrawUnwind()
        {
            LayoutDrawUnwind(
                EditorGUILayout.GetControlRect(true, element.GetFootprintHeight()),
                EditorGUISettings.GetInstance().GetInitialLayoutState()
            );
        }

        public EditorGUIElement GetElement()
        {
            return element;
        }
    }
}