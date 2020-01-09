using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    [AttributeUsage(AttributeTargets.Assembly)]
    public abstract class InspectAssemblysAttribute : Attribute
    {
        public abstract IEnumerable<Assembly> GetAssemblys();
    }
}