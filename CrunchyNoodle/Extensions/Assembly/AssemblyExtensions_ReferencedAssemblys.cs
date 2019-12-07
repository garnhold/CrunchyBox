using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class AssemblyExtensions_ReferencedAssemblys
    {
        static private OperationCache<List<Assembly>, Assembly> GET_IMMEDIATE_REFERENCED_ASSEMBLYS = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_REFERENCED_ASSEMBLYS", delegate (Assembly item) {
            return item.GetReferencedAssemblies()
                .Convert(n => n.GetAssembly())
                .SkipNull()
                .ToList();
        });
        static public IEnumerable<Assembly> GetImmediateReferencedAssemblys(this Assembly item)
        {
            return GET_IMMEDIATE_REFERENCED_ASSEMBLYS.Fetch(item);
        }

        static private OperationCache<List<Assembly>, Assembly> GET_REFERENCED_ASSEMBLYS = ReflectionCache.Get().NewOperationCache("GET_REFERENCED_ASSEMBLYS", delegate (Assembly item) {
            return item.TraverseWeb(i => i.GetImmediateReferencedAssemblys())
                .ToList();
        });
        static public IEnumerable<Assembly> GetReferencedAssemblys(this Assembly item)
        {
            return GET_REFERENCED_ASSEMBLYS.Fetch(item);
        }

        static private OperationCache<HashSet<string>, Assembly> REFERENCED_ASSEMBLY_NAMES_SET = ReflectionCache.Get().NewOperationCache("REFERENCED_ASSEMBLY_NAMES_SET", delegate(Assembly item) {
            return item.GetReferencedAssemblys()
                .Convert(a => a.GetSimpleName())
                .ToHashSet();
        });

        static public bool DoesReferenceAssembly(this Assembly item, Assembly assembly)
        {
            return REFERENCED_ASSEMBLY_NAMES_SET.Fetch(item).Contains(assembly.GetSimpleName());
        }
        static public bool IsReferencedByAssembly(this Assembly item, Assembly assembly)
        {
            return assembly.DoesReferenceAssembly(item);
        }
    }
}