using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class TypeExtensions_ChildType
    {
        static private OperationCache<Dictionary<Type, List<Type>>> GET_TYPE_HEIRARCHY = ReflectionCache.Get().NewOperationCache("GET_TYPE_HEIRARCHY", delegate() {
            return Types.GetFilteredTypes()
                .Narrow(t => t.BaseType != null)
                .ToMultiDictionary(t => t.BaseType);
        });

        static public IEnumerable<Type> GetImmediateChildTypes(this Type item)
        {
            return GET_TYPE_HEIRARCHY.Fetch().GetValues(item);
        }

        static private OperationCache<HashSet<Type>, Type> GET_ALL_CHILD_TYPES = ReflectionCache.Get().NewOperationCache("GET_ALL_CHILD_TYPES", delegate(Type item) {
            if (item.CanHaveChildTypes())
                return item.TraverseTree(t => t.GetImmediateChildTypes()).ToHashSet();

            return new HashSet<Type>();
        });
        static public IEnumerable<Type> GetAllChildTypes(this Type item)
        {
            return GET_ALL_CHILD_TYPES.Fetch(item);
        }

        static private OperationCache<List<Type>, Type, TypeFilters> GET_FILTERED_CHILD_TYPES = ReflectionCache.Get().NewOperationCache("GET_FILTERED_CHILD_TYPES", delegate(Type item, TypeFilters filters) {
            return item.GetAllChildTypes()
                .FilterBy(filters)
                .ToList();
        });
        static public IEnumerable<Type> GetFilteredChildTypes(this Type item, IEnumerable<Filterer<Type>> filters)
        {
            return GET_FILTERED_CHILD_TYPES.Fetch(item, new TypeFilters(filters));
        }
        static public IEnumerable<Type> GetFilteredChildTypes(this Type item, params Filterer<Type>[] filters)
        {
            return item.GetFilteredChildTypes((IEnumerable<Filterer<Type>>)filters);
        }

        static public bool HasChildTypes(this Type item)
        {
            if (item.CanHaveChildTypes())
            {
                if (item.GetImmediateChildTypes().IsNotEmpty())
                    return true;
            }

            return false;
        }
    }
}