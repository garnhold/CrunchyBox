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
    public abstract class EditorGUIElement_EditPropertySingleValueBrowse<T> : EditorGUIElement where T : UnityEngine.Object
    {
        private EditProperty_Single_Value property;

        private Rect field_rect;
        private Rect browse_rect;

        protected abstract EditorGUIElement CreateAssetElement(T asset);

        protected virtual T DrawValueInternal(Rect rect, T value)
        {
            return (T)EditorGUI.ObjectField(rect, value, typeof(T), false);
        }

        protected override Rect LayoutElementInternal(Rect rect, EditorGUILayoutState state)
        {
            rect.SplitByXRightOffset(60.0f, out field_rect, out browse_rect);

            return rect;
        }

        protected override void DrawElementInternal(Rect view)
        {
            T old_value;

            if (property.TryGetContentValues<T>(out old_value))
            {
                T new_value = DrawValueInternal(field_rect, old_value);

                if (new_value.NotEqualsEX(old_value))
                    property.SetContentValues(new_value);

                if (GUI.Button(browse_rect, "Browse"))
                {
                    ModalEditorWindow.OpenWindow("Browse", delegate(EditorGUIElement_Container_Auto container) {
                        container.AddChildren(
                            AssetDatabaseExtensions.GetAssets<T>(false)
                                .Convert(a => CreateAssetElement(a))
                        );
                    });
                }
            }
            else
            {
                EditorGUI.LabelField(GetElementRect(), "(Non-Unified Value)");
            }
        }

        public EditorGUIElement_EditPropertySingleValueBrowse(EditProperty_Single_Value p)
        {
            property = p;
        }

        public EditProperty_Single_Value GetProperty()
        {
            return property;
        }
    }
}