﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    public abstract class EditorGUIElement_EditPropertySingleValue_Browse<T> : EditorGUIElement_EditPropertySingleValue<T> where T : UnityEngine.Object
    {
        private Predicate<AssetInfo> predicate;

        private Rect field_rect;
        private Rect clear_rect;
        private Rect browse_rect;

        protected abstract EditorGUIElement CreateAssetInfoElement(AssetInfo info);

        protected virtual T DrawValueInternal(Rect rect, T value)
        {
            return EditorGUIExtensions.ObjectField<T>(rect, value);
        }

        protected override Rect LayoutElementInternal(Rect rect)
        {
            rect.SplitByXRightOffset(20.0f, out rect, out clear_rect);
            rect.SplitByXRightOffset(60.0f, out rect, out browse_rect);

            field_rect = rect;
            return rect;
        }

        protected override void DrawUnifiedElementInternal(Rect rect, T old_value)
        {
            T new_value = DrawValueInternal(field_rect, old_value);

            if (new_value.NotEqualsEX(old_value))
                GetProperty().SetContentValues(new_value);

            if (GUI.Button(browse_rect, "Browse"))
            {
                ModalEditorWindows.General("Browse", delegate(EditorGUIElement_Container_Auto container) {
                    container.AddChildren(
                        Project.GetExternalAssetInfos<T>()
                            .Narrow(predicate)
                            .Convert(a => CreateAssetInfoElement(a))
                    );
                });
            }

            if (GUI.Button(clear_rect, "X"))
                GetProperty().SetContentValues(null);
        }

        public EditorGUIElement_EditPropertySingleValue_Browse(EditProperty_Single_Value p, Predicate<AssetInfo> pre) : base(p)
        {
            predicate = pre;
        }

        public EditorGUIElement_EditPropertySingleValue_Browse(EditProperty_Single_Value p) : this(p, a => true) { }
    }
}