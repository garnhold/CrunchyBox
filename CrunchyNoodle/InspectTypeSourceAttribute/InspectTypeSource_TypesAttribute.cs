using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class InspectTypeSource_TypesAttribute : InspectTypeSourceAttribute
    {
        private List<Type> types;

        public InspectTypeSource_TypesAttribute(params Type[] t)
        {
            types = t.ToList();
        }

        public override IEnumerable<Type> GetTypes()
        {
            return types;
        }
    }
}