using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class InspectTypeSource_AssemblysAttribute : InspectTypeSourceAttribute
    {
        private List<Assembly> assemblys;

        public InspectTypeSource_AssemblysAttribute(params Assembly[] a)
        {
            assemblys = a.ToList();
        }

        public override IEnumerable<Type> GetTypes()
        {
            return assemblys.Convert(a => (IEnumerable<Type>)a.GetTypes());
        }
    }
}