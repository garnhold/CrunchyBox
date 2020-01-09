using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Bun;
    using Sandwich;
    
    [EditorGUIElementForType(typeof(UnityEngine.Object), true)]
    public class EditorGUIElement_Composite_EditPropertySingleValue_UnityObject : EditorGUIElement_Composite_EditPropertySingleValue
    {
        private Type specific_type;

        protected override EditorGUIElement CreateElement()
        {
            AssetFieldAttribute asset_field_attribute;
            if (GetProperty().TryGetCustomAttributeOfType<AssetFieldAttribute>(true, out asset_field_attribute))
                return new EditorGUIElement_EditPropertySingleValue_Selector_Asset(GetProperty(), asset_field_attribute.ShouldForceNonNull());

            PrefabFieldAttribute prefab_field_attribute;
            if (GetProperty().TryGetCustomAttributeOfType<PrefabFieldAttribute>(true, out prefab_field_attribute))
                return new EditorGUIElement_EditPropertySingleValue_Popup_Prefab(GetProperty(), prefab_field_attribute.ShouldForceNonNull());

            return new BuiltIn(GetProperty(), specific_type);
        }

        public EditorGUIElement_Composite_EditPropertySingleValue_UnityObject(EditProperty_Single_Value p, Type s) : base(p)
        {
            specific_type = s;
        }

        public EditorGUIElement_Composite_EditPropertySingleValue_UnityObject(EditProperty_Single_Value p) : this(p, p.GetPropertyType()) { }

        private class BuiltIn : EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn<UnityEngine.Object>
        {
            private Type specific_type;

            protected override UnityEngine.Object DrawBuiltInInternal(Rect rect, GUIContent label, UnityEngine.Object value)
            {
                return EditorGUI.ObjectField(rect, label, value, specific_type);
            }

            public BuiltIn(EditProperty_Single_Value p, Type s) : base(p)
            {
                specific_type = s;
            }
        }
    }
}