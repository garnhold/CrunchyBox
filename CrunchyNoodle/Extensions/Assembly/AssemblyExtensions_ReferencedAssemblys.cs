using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class AssemblyExtensions_ReferencedAssemblys
    {
        static private OperationCache<HashSet<string>, Assembly> IMMEDIATE_REFERENCED_ASSEMBLY_NAMES_SET = ReflectionCache.Get().NewOperationCache(delegate(Assembly item) {
            return item.GetReferencedAssemblies()
                .Convert(a => a.GetSimpleName())
                .Append(item.GetSimpleName())
                .ToHashSet();
        });
        static public IEnumerable<string> GetImmediateReferencedAssemblyNames(this Assembly item)
        {
            return IMMEDIATE_REFERENCED_ASSEMBLY_NAMES_SET.Fetch(item);
        }

        static public bool DoesReferenceAssembly(this Assembly item, Assembly assembly)
        {
            return IMMEDIATE_REFERENCED_ASSEMBLY_NAMES_SET.Fetch(item).Contains(assembly.GetSimpleName());
        }
        static public bool IsReferencedByAssembly(this Assembly item, Assembly assembly)
        {
            return assembly.DoesReferenceAssembly(item);
        }
    }
}