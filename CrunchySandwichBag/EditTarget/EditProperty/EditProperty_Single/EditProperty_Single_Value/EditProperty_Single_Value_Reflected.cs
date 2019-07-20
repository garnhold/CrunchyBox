using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditProperty_Single_Value_Reflected : EditProperty_Single_Value
    {
        private ReflectedProperty_Single_Value property;

        public EditProperty_Single_Value_Reflected(EditTarget t, ReflectedProperty_Single_Value p) : base(t)
        {
            property = p;
        }

        public override void ClearContents()
        {
            property.ClearContents();
        }

        public override void EnsureContents(Type type)
        {
            property.EnsureContents(type);
        }

        public override void SetContentValues(object value)
        {
            property.SetContentValues(value);
        }

        public override bool IsUnified()
        {
            return property.IsUnified();
        }

        public override bool TryGetContentValues(out object value)
        {
            return property.TryGetContentValues(out value);
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
    }
}