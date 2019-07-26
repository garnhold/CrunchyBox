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
    public abstract class EditorGUIElement_EditPropertySingleValueSelector<T> : EditorGUIElement
    {
        private EditProperty_Single_Value property;

        public abstract IEnumerable<AssetInfo> GetAssetInfos();

        protected override void DrawElementInternal(Rect view)
        {
            T old_value;

            if (property.TryGetContentValues<T>(out old_value))
            {
                if (EditorGUIExtensions.DropdownButton(GetElementRect(), old_value.ToStringEX("None")))
                {
                    GenericMenu menu = new GenericMenu();

                    foreach (AssetInfo option in GetAssetInfos())
                        menu.AddItem(option.ToStringEX("None"), () => property.SetContentValues(option.Resolve<T>()));

                    menu.ShowAsContext();
                }
            }
            else
            {
                EditorGUI.LabelField(GetElementRect(), "(Non-Unified Value)");
            }
        }

        public EditorGUIElement_EditPropertySingleValueSelector(EditProperty_Single_Value p)
        {
            property = p;
        }

        public EditProperty_Single_Value GetProperty()
        {
            return property;
        }
    }
}