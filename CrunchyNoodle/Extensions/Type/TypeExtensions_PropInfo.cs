using System;
using System.Reflection;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_PropInfo
    {
        static private OperationCache<PropInfoEX, Type, string> GET_INSTANCE_PROP = ReflectionCache.Get().NewOperationCache("GET_INSTANCE_PROP", delegate(Type item, string name) {
            if (name.EndsWith("()"))
                return item.GetInstanceMethodProp(name);

            return item.GetInstanceFieldProp(name) ??
                item.GetInstancePropertyProp(name) ??
                item.GetInstanceMethodProp(name);
        });
        static public PropInfoEX GetInstanceProp(this Type item, string name)
        {
            return GET_INSTANCE_PROP.Fetch(item, name);
        }

        static private OperationCache<List<PropInfoEX>, Type> GET_ALL_INSTANCE_PROPS = ReflectionCache.Get().NewOperationCache("GET_ALL_INSTANCE_PROPS", delegate(Type type) {
            return type.GetAllInstanceMethodProps()
                .Append(type.GetAllInstanceFieldProps())
                .ToList();
        });
        static public IEnumerable<PropInfoEX> GetAllInstanceProps(this Type item)
        {
            return GET_ALL_INSTANCE_PROPS.Fetch(item);
        }

        static private OperationCache<List<PropInfoEX>, Type, PropInfoFilters> GET_FILTERED_INSTANCE_PROPS = ReflectionCache.Get().NewOperationCache("GET_FILTERED_INSTANCE_PROPS", delegate(Type type, PropInfoFilters filters) {
            return type.GetAllInstanceProps()
                .FilterBy(filters)
                .ToList();
        });
        static public IEnumerable<PropInfoEX> GetFilteredInstanceProps(this Type item, IEnumerable<Filterer<PropInfoEX>> filters)
        {
            return GET_FILTERED_INSTANCE_PROPS.Fetch(item, new PropInfoFilters(filters));
        }
        static public IEnumerable<PropInfoEX> GetFilteredInstanceProps(this Type item, params Filterer<PropInfoEX>[] filters)
        {
            return item.GetFilteredInstanceProps((IEnumerable<Filterer<PropInfoEX>>)filters);
        }
    }
}