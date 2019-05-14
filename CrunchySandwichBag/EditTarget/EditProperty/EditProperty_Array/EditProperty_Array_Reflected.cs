﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditProperty_Array_Reflected : EditProperty_Array
    {
        private ReflectedProperty_Array property;

        public EditProperty_Array_Reflected(EditTarget t, ReflectedProperty_Array p) : base(t)
        {
            property = p;
        }

        public override void InsertElement(int index)
        {
            property.InsertElement(index);
        }

        public override void RemoveElement(int index)
        {
            property.RemoveElement(index);
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