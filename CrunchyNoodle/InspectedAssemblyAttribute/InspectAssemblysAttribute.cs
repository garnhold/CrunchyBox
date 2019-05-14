using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public abstract class InspectAssemblysAttribute : Attribute
    {
        public abstract IEnumerable<Assembly> GetAssemblys();
    }
}