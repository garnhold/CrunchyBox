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
    public class EditProperty_Value_Reflected : EditProperty_Value
    {
        private ReflectedProperty_Value property;

        public EditProperty_Value_Reflected(EditTarget t, ReflectedProperty_Value p) : base(t)
        {
            property = p;
        }

        public override void SetContents(object value)
        {
            property.SetContents(value);
        }

        public override bool IsUnified()
        {
            return property.IsUnified();
        }

        public override bool TryGetContents(out object value)
        {
            return property.TryGetContents(out value);
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