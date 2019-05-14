using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class InspectAssemblys_ByTypeAttribute : InspectAssemblysAttribute
    {
        private List<Type> types;

        public InspectAssemblys_ByTypeAttribute(params Type[] t)
        {
            types = t.ToList();
        }

        public override IEnumerable<Assembly> GetAssemblys()
        {
            return types.Convert(t => t.Assembly);
        }
    }
}