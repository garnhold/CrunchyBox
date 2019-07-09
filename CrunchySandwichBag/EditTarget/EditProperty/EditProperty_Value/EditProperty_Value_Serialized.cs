using System;
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
    public class EditProperty_Value_Serialized : EditProperty_Value
    {
        private SerializedProperty property;

        public EditProperty_Value_Serialized(EditTarget t, SerializedProperty p) : base(t)
        {
            property = p;
        }

        public override void SetContents(object value)
        {
            property.SetValue(value);
        }

        public override bool IsUnified()
        {
            if (property.hasMultipleDifferentValues == false)
                return true;

            return false;
        }

        public override bool TryGetContents(out object value)
        {
            if (IsUnified())
            {
                value = property.GetValue(GetPropertyType());
                return true;
            }

            value = null;
            return false;
        }

        public override bool TryGetContents(out EditTarget value)
        {
            value = new EditTarget_Serialized_Property(property);

            return true;
        }

        public override string GetName()
        {
            return property.name;
        }

        public override Type GetPropertyType()
        {
            return property.GetVariableType();
        }

        public override bool TryGetContentsType(out Type type)
        {
            object value;

            if (TryGetContents(out value))
            {
                type = value.GetTypeEX();
                return true;
            }

            type = null;
            return false;
        }

        public override IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return property.GetAllCustomAttributes(inherit);
        }

        protected override EditorGUIElement CreateEditorGUIElementInternal()
        {
            return CustomPropertyDrawers.GetPropertyDrawer(GetPropertyType())
                .IfNotNull(d => d.CreateEditorGUIElement(property))
                ??
                base.CreateEditorGUIElementInternal();
        }
    }
}