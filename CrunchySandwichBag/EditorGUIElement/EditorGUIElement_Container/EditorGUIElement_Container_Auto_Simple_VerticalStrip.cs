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
        protected override bool HandleAttachment(ref EditorGUIElementAttachment attachment)
        {
            EditorGUIElementAttachment_Singular_GUIContentLabel_Inline label;

            if (attachment.Convert<EditorGUIElementAttachment_Singular_GUIContentLabel_Inline>(out label))
                attachment = new EditorGUIElementAttachment_Singular_GUIContentLabel_Block(label.GetLabel());

            return base.HandleAttachment(ref attachment);
        }

        protected override void LayoutContentsInternal(Rect rect, float label_width)
        {
            Rect remaining_rect = rect;

            foreach (EditorGUIElement element in GetChildren())
            {
                Rect current_rect;

                remaining_rect.SplitByYBottomOffset(element.GetHeight(), out current_rect, out remaining_rect);
                element.Layout(current_rect, label_width);
            }
        }

        protected override float CalculateLayoutLabelWidthInternal(float incoming)
        {
            if (EditorGUISettings.GetInstance().ShouldShrinkLabels())
            {
                return GetChildren()
                    .Convert(c => c.GetAttachments<EditorGUIElementAttachment_Singular_GUIContentLabel>())
                    .Convert(a => a.GetLabel().GetLabelLayoutWidth())
                    .Max() + EditorGUISettings.GetInstance().GetShrunkLabelMargin();
            }

            return incoming;
        }

        protected override float CalculateElementHeightInternal()
        {
            return GetChildren().Convert(e => e.GetHeight()).Sum();
        }
    }
}