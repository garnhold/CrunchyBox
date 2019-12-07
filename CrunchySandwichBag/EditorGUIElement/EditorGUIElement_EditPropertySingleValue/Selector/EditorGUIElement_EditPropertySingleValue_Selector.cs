using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    public abstract class EditorGUIElement_EditPropertySingleValue_Selector<T> : EditorGUIElement_EditPropertySingleValue<T>
    {
        public abstract IEnumerable<AssetInfo> GetAssetInfos();

        protected override void DrawUnifiedElementInternal(Rect rect, T old_value)
        {
            if (EditorGUIExtensions.DropdownButton(GetElementRect(), old_value.ToStringEX("None")))
            {
                GenericMenu menu = new GenericMenu();

                foreach (AssetInfo option in GetAssetInfos())
                    menu.AddItem(option.ToStringEX("None"), () => GetProperty().SetContentValues(option.Resolve<T>()));

                menu.ShowAsContext();
            }
        }

        public EditorGUIElement_EditPropertySingleValue_Selector(EditProperty_Single_Value p) : base(p) { }
    }
}