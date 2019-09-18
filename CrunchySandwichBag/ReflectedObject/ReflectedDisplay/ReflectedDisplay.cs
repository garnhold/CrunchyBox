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
    public class ReflectedDisplay : IDynamicCustomAttributeProvider
    {
        private ReflectedObject reflected_object;
        private Variable variable;

        static public ReflectedDisplay New(ReflectedObject reflected_object, Variable variable)
        {
            return new ReflectedDisplay(reflected_object, variable);
        }

        public ReflectedDisplay(ReflectedObject o, Variable v)
        {
            reflected_object = o;
            variable = v;
        }

        public string GetDisplayName()
        {
            return variable.GetVariableName();
        }

        public IEnumerable<object> GetValues()
        {
            return reflected_object.GetObjects().Convert(o => variable.GetContents(o));
        }

        public bool TryGetValue(out object value)
        {
            return GetValues().AreAllSame(out value);
        }

        public ReflectedObject GetReflectedObject()
        {
            return reflected_object;
        }

        public IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return variable.GetAllCustomAttributes(inherit);
        }
    }
}