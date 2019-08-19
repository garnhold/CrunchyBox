using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public partial class Types
    {
        static private OperationCache<List<Type>> GET_ALL_INSPECTED_TYPES = ReflectionCache.Get().NewOperationCache("GET_ALL_INSPECTED_TYPES", delegate() {
            return Assemblys.GetAllInspectedAssemblys()
                .Convert(a => a.GetAllCustomAttributesOfType<InspectedTypesAttribute>(true))
                .Convert(a => a.GetTypes())
                .Unique()
                .ToList();
        });
        static public IEnumerable<Type> GetAllInspectedTypes()
        {
            return GET_ALL_INSPECTED_TYPES.Fetch();
        }
    }
}