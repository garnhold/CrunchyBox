using System;
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
    
    public class EditProperty_Value_Serialized : EditProperty_Single_Value
    {
        private SerializedProperty property;

        public EditProperty_Value_Serialized(EditTarget t, SerializedProperty p) : base(t)
        {
            property = p;
        }

        public override void ClearContents()
        {
            property.ClearValue();
        }

        public override void CreateContents(Type type)
        {
            property.ClearValue();
        }

        public override void EnsureContents(Type type)
        {
            //Intentionally Blank
        }

        public override void ForceContentValues(object value)
        {
            property.SetValue(value);
            property.serializedObject.ApplyModifiedProperties();

            Debug.Log("Forcing SerializedObject to apply per property.");
        }

        public override bool IsUnified()
        {
            return property.IsUnified();
        }

        public override bool TryGetContentValues(out object value)
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

            if (TryGetContentValues(out value))
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