using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    public class EditorGUIElementAttachment_Box : EditorGUIElementAttachment
    {
        private Color color;

        private EditorGUIElementPlan box_plan;
        private Rect box_rect;

        public EditorGUIElementAttachment_Box(Color c)
        {
            color = c;
        }

        public EditorGUIElementAttachment_Box() : this(Color.gray) { }

        public override EditorGUIElementPlan PlanElementInternal(EditorGUIElementPlan plan, EditorGUILayoutState state)
        {
            box_plan = plan;

            return plan;
        }

        public override void LayoutInternal(Vector2 position, float footprint_height)
        {
            box_rect = box_plan.Layout(position, footprint_height);
        }

        public override void PreDrawInternal()
        {
            EditorGUI.DrawRect(box_rect, color);
        }
    }
}