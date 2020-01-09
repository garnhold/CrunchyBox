using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class AssemblyExtensions_SimpleName
    {
        static public string GetSimpleName(this Assembly item)
        {
            return item.GetName().Name;
        }
    }
}