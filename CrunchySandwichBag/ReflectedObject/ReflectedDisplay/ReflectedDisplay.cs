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
            return reflected_object.GetObjects().Convert(delegate(object obj) {
                try
                {
                    return variable.GetContents(obj);
                }
                catch (Exception ex)
                {
                    return ex;
                }
            });
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