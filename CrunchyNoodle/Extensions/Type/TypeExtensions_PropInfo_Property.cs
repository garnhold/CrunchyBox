using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class TypeExtensions_PropInfo_Property
    {
		static private OperationCache<PropInfoEX, Type, string> GET_INSTANCE_PROPERTY_PROP = ReflectionCache.Get().NewOperationCache(delegate(Type item, string name){
            return item.GetInstanceMethodPropInternal(
                name.GetEntityPropertySetMethodName(),
                name.GetEntityPropertyGetMethodName()
            );
		});
		static public PropInfoEX GetInstancePropertyProp(this Type item, string name)
		{
            return GET_INSTANCE_PROPERTY_PROP.Fetch(item, name);
		}
    }
}