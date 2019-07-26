using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [EditorGUIElementForType(typeof(UnityEngine.Object), true)]
    public class EditorGUIElement_Composite_EditPropertySingleValue_UnityObject : EditorGUIElement_Composite_EditPropertySingleValue
    {
        protected override EditorGUIElement CreateElement()
        {
            AssetFieldAttribute asset_field_attribute;
            if (GetProperty().TryGetCustomAttributeOfType<AssetFieldAttribute>(true, out asset_field_attribute))
                return new EditorGUIElement_EditPropertySingleValueSelector_Asset(GetProperty(), asset_field_attribute.ShouldForceNonNull());

            PrefabFieldAttribute prefab_field_attribute;
            if (GetProperty().TryGetCustomAttributeOfType<PrefabFieldAttribute>(true, out prefab_field_attribute))
                return new EditorGUIElement_EditPropertySingleValuePopup_Prefab(GetProperty(), prefab_field_attribute.ShouldForceNonNull());

            return new BuiltIn(GetProperty());
        }

        public EditorGUIElement_Composite_EditPropertySingleValue_UnityObject(EditProperty_Single_Value p) : base(p) { }

        private class BuiltIn : EditorGUIElement_EditPropertySingleValue_BuiltIn<UnityEngine.Object>
        {
            protected override UnityEngine.Object DrawBuiltInInternal(Rect rect, GUIContent label, UnityEngine.Object value)
            {
                return EditorGUI.ObjectField(rect, label, value, GetProperty().GetPropertyType());
            }

            public BuiltIn(EditProperty_Single_Value p) : base(p) { }
        }
    }
}