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
    public class EditorGUIElementAttachment_Singular_Label_GUIContent_Block : EditorGUIElementAttachment_Singular_Label_GUIContent
    {
        private EditorGUIElementPlan label_plan;
        private Rect label_rect;

        private float indent_width;
        private float label_height;

        public EditorGUIElementAttachment_Singular_Label_GUIContent_Block(GUIContent l, float i, float h) : base(l)
        {
            indent_width = i;
            label_height = h;
        }

        public EditorGUIElementAttachment_Singular_Label_GUIContent_Block(GUIContent l, float i) : this(l, i, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
        public EditorGUIElementAttachment_Singular_Label_GUIContent_Block(GUIContent l) : this(l, EditorGUIElement_Single.DEFAULT_HEIGHT) { }

        public override EditorGUIElementPlan PlanContentsInternal(EditorGUIElementPlan plan, EditorGUILayoutState state)
        {
            if (HasLabel())
                plan.SplitAtBottomOffset(label_height, out label_plan, out plan);

            return plan.Shrink(indent_width, 0.0f, 0.0f, 0.0f);
        }

        public override float ModifyFootprintHeight(float height, EditorGUILayoutState state)
        {
            if (HasLabel())
                return height + label_height;

            return height;
        }

        public override void LayoutInternal(Vector2 position, float footprint_height)
        {
            label_rect = label_plan.Layout(position, EditorGUIElement.LINE_HEIGHT);
        }

        public override void DrawInternal(Rect view)
        {
            if (HasLabel())
                GUI.Label(label_rect, GetLabel());
        }
    }
}