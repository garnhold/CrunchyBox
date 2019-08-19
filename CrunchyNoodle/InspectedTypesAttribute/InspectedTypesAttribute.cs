using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class InspectedTypesAttribute : Attribute
    {
        private List<Type> types;

        public InspectedTypesAttribute(params Type[] t)
        {
            types = t.ToList();
        }

        public IEnumerable<Type> GetTypes()
        {
            return types;
        }
    }
}