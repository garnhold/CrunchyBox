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
    public class EditProperty_Object_Serialized : EditProperty_Object
    {
        private SerializedProperty property;

        public EditProperty_Object_Serialized(EditTarget t, SerializedProperty p) : base(t)
        {
            property = p;
        }

        public override void ClearContents()
        {
            property.ClearValue();
        }

        public override void CreateContents(Type type)
        {
            property.SetValue(type.CreateInstance());
        }

        public override void EnsureContents(Type type)
        {
            if (property.hasMultipleDifferentValues == false)
            {
                if (property.GetValue().GetTypeEX() != type)
                    CreateContents(type);
            }
        }

        public override bool IsUnified()
        {
            if (property.hasMultipleDifferentValues == false)
                return true;

            return false;
        }

        public override bool TryGetContents(out EditTarget value)
        {
            if(IsUnified())
            {
                value = new EditTarget_Serialized_Property(property);
                return true;
            }

            value = null;
            return false;
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
            if (property.hasMultipleDifferentValues == false)
            {
                type = property.GetVariableType();
                return true;
            }

            type = null;
            return false;
        }

        public override IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return property.GetAllCustomAttributes(inherit);
        }
    }
}