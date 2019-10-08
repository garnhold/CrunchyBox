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
    public abstract class EditorGUIElement_EditPropertySingleValue_Browse<T> : EditorGUIElement_EditPropertySingleValue<T> where T : UnityEngine.Object
    {
        private Rect field_rect;
        private Rect browse_rect;

        protected abstract EditorGUIElement CreateAssetInfoElement(AssetInfo info);

        protected virtual T DrawValueInternal(Rect rect, T value)
        {
            return (T)EditorGUI.ObjectField(rect, value, typeof(T), false);
        }

        protected override Rect LayoutElementInternal(Rect rect)
        {
            rect.SplitByXRightOffset(60.0f, out field_rect, out browse_rect);

            return rect;
        }

        protected override void DrawUnifiedElementInternal(Rect rect, T old_value)
        {
            T new_value = DrawValueInternal(field_rect, old_value);

            if (new_value.NotEqualsEX(old_value))
                GetProperty().SetContentValues(new_value);

            if (GUI.Button(browse_rect, "Browse"))
            {
                ModalEditorWindow.OpenWindow("Browse", delegate(EditorGUIElement_Container_Auto container) {
                    container.AddChildren(
                        Project.GetExternalAssetInfos<T>()
                            .Convert(a => CreateAssetInfoElement(a))
                    );
                });
            }
        }

        public EditorGUIElement_EditPropertySingleValue_Browse(EditProperty_Single_Value p) : base(p) { }
    }
}