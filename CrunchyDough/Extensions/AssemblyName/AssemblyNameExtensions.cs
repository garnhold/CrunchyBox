using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class AssemblyNameExtensions
    {
        static private Dictionary<string, Assembly> ASSEMBLYS;
        static public Assembly GetAssembly(this AssemblyName item)
        {
            if (ASSEMBLYS == null)
                ASSEMBLYS = AppDomain.CurrentDomain.GetAssemblies().ToDictionaryValues(a => a.GetSimpleName());

            return ASSEMBLYS.GetOrCreateValue(item.GetSimpleName(), () => Assembly.Load(item));
        }
    }
}