using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_PropInfo_Field
    {
        static private OperationCache<PropInfoEX, Type, string> GET_INSTANCE_FIELD_PROP = ReflectionCache.Get().NewOperationCache("GET_INSTANCE_FIELD_PROP", delegate(Type item, string name) {
            return item.GetInstanceField(name).IfNotNull(f => (PropInfoEX)new PropInfoEX_Field(f));
		});
		static public PropInfoEX GetInstanceFieldProp(this Type item, string name)
		{
            return GET_INSTANCE_FIELD_PROP.Fetch(item, name);
		}

        static private OperationCache<List<PropInfoEX>, Type> GET_ALL_INSTANCE_FIELD_PROPS = ReflectionCache.Get().NewOperationCache("GET_ALL_INSTANCE_FIELD_PROPS", delegate(Type item) {
            return item.GetAllInstanceFields()
                .Convert(f => item.GetInstanceFieldProp(f.Name))
                .SkipNull()
                .ToList();
        });
        static public IEnumerable<PropInfoEX> GetAllInstanceFieldProps(this Type item)
        {
            return GET_ALL_INSTANCE_FIELD_PROPS.Fetch(item);
        }
    }
}