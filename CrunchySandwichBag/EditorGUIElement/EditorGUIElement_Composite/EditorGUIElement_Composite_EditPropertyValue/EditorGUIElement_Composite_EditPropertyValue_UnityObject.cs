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
    public class EditorGUIElement_Composite_EditPropertyValue_UnityObject : EditorGUIElement_Composite_EditPropertyValue
    {
        static private EditorGUIElement CreateElement(EditProperty_Value property)
        {
            AssetFieldAttribute asset_field_attribute;
            if (property.TryGetCustomAttributeOfType<AssetFieldAttribute>(true, out asset_field_attribute))
                return new EditorGUIElement_EditPropertyValue_Popup_Asset(property, asset_field_attribute.ShouldForceNonNull());

            PrefabFieldAttribute prefab_field_attribute;
            if (property.TryGetCustomAttributeOfType<PrefabFieldAttribute>(true, out prefab_field_attribute))
                return new EditorGUIElement_EditPropertyValue_Popup_Prefab(property, prefab_field_attribute.ShouldForceNonNull());

            return new BuiltIn(property);
        }

        public EditorGUIElement_Composite_EditPropertyValue_UnityObject(EditProperty_Value p) : base(CreateElement(p), p) { }

        private class BuiltIn : EditorGUIElement_EditPropertyValue_BuiltIn<UnityEngine.Object>
        {
            protected override UnityEngine.Object DrawBuiltInInternal(Rect rect, GUIContent label, UnityEngine.Object value)
            {
                return EditorGUI.ObjectField(rect, label, value, GetProperty().GetPropertyType());
            }

            public BuiltIn(EditProperty_Value p) : base(p) { }
        }
    }
}