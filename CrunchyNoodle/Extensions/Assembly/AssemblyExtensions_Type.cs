using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class AssemblyExtensions_Type
    {
        static private OperationCache<List<Type>, Assembly> GET_ALL_DEFINED_TYPES = ReflectionCache.Get().NewOperationCache("GET_ALL_DEFINED_TYPES", delegate(Assembly item) {
            return item.GetTypes()
                .ToList();
        });
        static public IEnumerable<Type> GetAllDefinedTypes(this Assembly item)
        {
            return GET_ALL_DEFINED_TYPES.Fetch(item);
        }
    }
}