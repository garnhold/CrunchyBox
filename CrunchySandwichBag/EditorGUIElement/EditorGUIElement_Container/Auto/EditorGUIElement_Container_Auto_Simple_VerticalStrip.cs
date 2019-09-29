﻿using System;
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
        protected override float DoPlanInternal()
        {
            EditorGUILayoutState state = GetLayoutState();

            if (state.ShouldAutoSizeLabels())
            {
                state = state.GetWithCurrentLabelWidth(
                    GetChildren()
                        .Convert(c => c.GetAttachments<EditorGUIElementAttachment_Singular_Label_GUIContent_Inline>())
                        .Convert(a => a.GetLabel().GetLabelLayoutWidth())
                        .Max() + state.GetAutoSizeLabelMargin()
                );
            }

            return GetChildren().Convert(e => e.Plan(GetContentsWidth(), state)).Sum();
        }

        protected override void LayoutContentsInternal(Vector2 position)
        {
            foreach (EditorGUIElement element in GetChildren())
            {
                element.Layout(position);
                position.y += element.GetFootprintHeight();
            }
        }
    }
}