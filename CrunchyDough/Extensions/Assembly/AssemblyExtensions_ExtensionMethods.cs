using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Crunchy.Dough
{
    static public class AssemblyExtensions_ExtensionMethods
    {
        static public bool ContainsExtensionTypes(this Assembly item)
        {
            if (item.HasCustomAttributeOfType<ExtensionAttribute>(false))
                return true;

            return false;
        }
    }
}