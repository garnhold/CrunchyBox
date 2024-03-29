﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    public class EditorGUIView
    {
        private Rect visible_rect;
        private EditorGUIElement element;

        private int next_draw_id;

        public EditorGUIView(EditorGUIElement e)
        {
            element = e;

            next_draw_id = 1;
        }

        public void LayoutDrawUnwind(Rect rect, EditorGUILayoutState state)
        {
            if (state.ShouldUseVisibility())
            {
                if (Event.current.type == EventType.Repaint)
                {
                    Rect new_visible_rect = GUIUtilityExtensions.GetVisibleRect();

                    if (new_visible_rect.height <= Screen.height && new_visible_rect.height >= 16.0f)
                        visible_rect = new_visible_rect;
                }
            }
            else
            {
                visible_rect = rect;
            }

            if (rect.width > 16.0f)
            {
                int draw_id = next_draw_id++;

                element.Plan(rect.width, state);
                element.Layout(rect.min);

                element.Draw(draw_id, visible_rect);
                element.Unwind(draw_id);
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