using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Bun;
    using Sandwich;
    
    public class EditProperty_Array_Reflected : EditProperty_Array
    {
        private ReflectedProperty_Array property;

        public EditProperty_Array_Reflected(EditTarget t, ReflectedProperty_Array p) : base(t)
        {
            property = p;
        }

        public override void ClearContents()
        {
            property.ClearContents();
        }

        public override void CreateContents(Type type)
        {
            property.CreateContents(type);
        }

        public override void EnsureContents(Type type)
        {
            property.EnsureContents(type);
        }

        public override void ForceContentValues(object value)
        {
            property.ForceContentValues(value);
        }

        public override void InsertElement(int index)
        {
            property.InsertElement(index);
        }

        public override void RemoveElement(int index)
        {
            property.RemoveElement(index);
        }

        public override void MoveElement(int src_index, int dst_index)
        {
            property.MoveElement(src_index, dst_index);
        }

        public override bool IsUnified()
        {
            return property.IsUnified();
        }

        public override EditProperty GetElement(int index)
        {
            return EditTarget_Reflected.CreateProperty(GetTarget(), property.GetElement(index));
        }

        public override bool TryGetNumberElements(out int number)
        {
            return property.TryGetNumberElements(out number);
        }

        public override string GetName()
        {
            return property.GetVariableName();
        }

        public override Type GetPropertyType()
        {
            return property.GetVariableType();
        }

        public override Type GetElementType()
        {
            return property.GetElementType();
        }

        public override IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return property.GetAllCustomAttributes(inherit);
        }
    }
}