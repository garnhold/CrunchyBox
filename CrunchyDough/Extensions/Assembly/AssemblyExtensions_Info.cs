using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Crunchy.Dough
{
    static public class AssemblyExtensions_Info
    {
        static public string GetAssemblyTitle(this Assembly item)
        {
            return item.GetCustomAttributeOfType<AssemblyTitleAttribute>(true).Title;
        }

        static public string GetAssemblyVersion(this Assembly item)
        {
            return item.GetCustomAttributeOfType<AssemblyVersionAttribute>(true).Version;
        }

        static public string GetAssemblyFileVersion(this Assembly item)
        {
            return item.GetCustomAttributeOfType<AssemblyFileVersionAttribute>(true).Version;
        }

        static public string GetAssemblyGUID(this Assembly item)
        {
            return item.GetCustomAttributeOfType<GuidAttribute>(true).Value;
        }

        static public string GetAssemblyId(this Assembly item)
        {
            return item.GetSimpleName() +
                item.GetCustomAttributeOfType<GuidAttribute>(true).IfNotNull(a => a.Value).SurroundVisible("{", "}");
        }
    }
}