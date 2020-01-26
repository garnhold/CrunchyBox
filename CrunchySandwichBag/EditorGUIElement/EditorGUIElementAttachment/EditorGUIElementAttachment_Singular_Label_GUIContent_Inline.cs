using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    public class EditorGUIElementAttachment_Singular_Label_GUIContent_Inline : EditorGUIElementAttachment_Singular_Label_GUIContent
    {
        private EditorGUIElementPlan label_plan;
        private Rect label_rect;

        public EditorGUIElementAttachment_Singular_Label_GUIContent_Inline(GUIContent l) : base(l)
        {
        }

        public EditorGUIElementAttachment_Singular_Label_GUIContent_Inline() : this(GUIContent.none) { }

        public override EditorGUIElementPlan PlanElementInternal(EditorGUIElementPlan plan, EditorGUILayoutState state)
        {
            if (HasLabel())
                plan.SplitAtLeftOffset(state.GetCurrentLabelWidth(), out label_plan, out plan);

            return plan;
        }

        public override void LayoutInternal(Vector2 position, float footprint_height)
        {
            label_rect = label_plan.Layout(position, footprint_height);
        }

        public override void DrawInternal(Rect view)
        {
            if (HasLabel())
                GUI.Label(label_rect, GetLabel());
        }
    }
}