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
    
    public class EditProperty_Single_Object_Reflected : EditProperty_Single_Object, EditPropertyReflected
    {
        private ReflectedProperty_Single_Object property;

        public EditProperty_Single_Object_Reflected(EditTarget t, ReflectedProperty_Single_Object p) : base(t)
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

        public override bool IsUnified()
        {
            return property.IsUnified();
        }

        public override bool TryGetContents(out EditTarget value)
        {
            ReflectedObject temp;
            bool to_return = property.TryGetContents(out temp);

            value = new EditTarget_Reflected(temp);
            return to_return;
        }

        public override string GetName()
        {
            return property.GetVariableName();
        }

        public override Type GetPropertyType()
        {
            return property.GetVariableType();
        }

        public override bool TryGetContentsType(out Type type)
        {
            return property.TryGetContentsType(out type);
        }

        public override IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return property.GetAllCustomAttributes(inherit);
        }

        public ReflectedProperty GetReflectedProperty()
        {
            return property;
        }
    }
}