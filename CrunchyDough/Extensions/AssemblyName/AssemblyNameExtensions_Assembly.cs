using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class AssemblyNameExtensions_Assembly
    {
        static private OperationCache<Assembly, string> GET_ASSEMBLY = ReflectionCache.Get().NewOperationCache("GET_ASSEMBLY", delegate (string name) {
            try
            {
                return AppDomain.CurrentDomain.GetAssemblies().FindFirst(a => a.GetSimpleName() == name) ??
                    Assembly.Load(name);
            }
            catch (Exception)
            {
            }

            return null;
        });
        static public Assembly GetAssembly(this AssemblyName item)
        {
            return GET_ASSEMBLY.Fetch(item.GetSimpleName());
        }
    }
}