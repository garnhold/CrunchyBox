using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchyNoodle;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIElement_Container_Auto_Simple_VerticalStrip : EditorGUIElement_Container_Auto_Simple
    {
        protected override void LayoutContentsInternal(Rect rect, EditorGUILayoutState state)
        {
            Rect remaining_rect = rect;

            if (state.ShouldAutoSizeLabels())
                state = state.GetWithCurrentLabelWidth(CalculateAutoSizeLabelWidth() + state.GetAutoSizeLabelMargin());

            foreach (EditorGUIElement element in GetChildren())
            {
                Rect current_rect;

                remaining_rect.SplitByYBottomOffset(element.GetHeight(), out current_rect, out remaining_rect);
                element.Layout(current_rect, state);
            }
        }

        protected override float CalculateElementHeightInternal()
        {
            return GetChildren().Convert(e => e.GetHeight()).Sum();
        }

        protected float CalculateAutoSizeLabelWidth()
        {
            return GetChildren()
                .Convert(c => c.GetAttachments<EditorGUIElementAttachment_Singular_Label_GUIContent>())
                .Convert(a => a.GetLabel().GetLabelLayoutWidth())
                .Max();
        }
    }
}