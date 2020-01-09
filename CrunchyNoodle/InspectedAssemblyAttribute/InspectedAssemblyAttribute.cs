using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    [AttributeUsage(AttributeTargets.Assembly)]
    public class InspectedAssemblyAttribute : Attribute
    {
    }
}