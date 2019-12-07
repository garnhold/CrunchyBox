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
    
    public class EditProperty_Array_Serialized : EditProperty_Array
    {
        private SerializedProperty property;

        public EditProperty_Array_Serialized(EditTarget t, SerializedProperty p) : base(t)
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
            //Intentionally blank
        }

        public override void ForceContentValues(object value)
        {
            property.SetValue(value);
            property.serializedObject.ApplyModifiedProperties();

            Debug.Log("Forcing SerializedObject to apply per property.");
        }

        public override void InsertElement(int index)
        {
            property.InsertAndNullArrayElementAtIndex(index);
        }

        public override void RemoveElement(int index)
        {
            property.DeleteArrayElementAtIndex(index);
        }

        public override void MoveElement(int src_index, int dst_index)
        {
            property.MoveArrayElement(src_index, dst_index);
        }

        public override bool IsUnified()
        {
            if (property.hasMultipleDifferentValues == false)
                return true;

            return false;
        }

        public override EditProperty GetElement(int index)
        {
            return EditTarget_Serialized.CreateProperty(GetTarget(), property.GetArrayElementAtIndex(index));
        }

        public override bool TryGetNumberElements(out int number)
        {
            if (IsUnified())
            {
                number = property.GetArraySize();
                return true;
            }

            number = 0;
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

        public override Type GetElementType()
        {
            return property.GetVariableType();
        }

        public override IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return property.GetAllCustomAttributes(inherit);
        }
    }
}