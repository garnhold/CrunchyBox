using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class ICustomAttributeProviderExtensions_GetValue
    {
        static public J GetCustomAttributeOfTypeValue<J, T>(this ICustomAttributeProvider item, bool inherit, Operation<J, T> operation) where T : Attribute
        {
            return item.GetCustomAttributeOfType<T>(inherit).IfNotNull(operation);
        }
        static public J GetCustomAttributeOfTypeValue<J, T>(this ICustomAttributeProvider item, bool inherit, Operation<J, T> operation, J if_null) where T : Attribute
        {
            return item.GetCustomAttributeOfType<T>(inherit).IfNotNull(operation, if_null);
        }
        static public J GetCustomAttributeOfTypeValue<J, T>(this ICustomAttributeProvider item, bool inherit, Operation<J, T> operation, Operation<J> if_null) where T : Attribute
        {
            return item.GetCustomAttributeOfType<T>(inherit).IfNotNull(operation, if_null);
        }
	}
	static public class IDynamicCustomAttributeProviderExtensions_GetValue
    {
        static public J GetCustomAttributeOfTypeValue<J, T>(this IDynamicCustomAttributeProvider item, bool inherit, Operation<J, T> operation) where T : Attribute
        {
            return item.GetCustomAttributeOfType<T>(inherit).IfNotNull(operation);
        }
        static public J GetCustomAttributeOfTypeValue<J, T>(this IDynamicCustomAttributeProvider item, bool inherit, Operation<J, T> operation, J if_null) where T : Attribute
        {
            return item.GetCustomAttributeOfType<T>(inherit).IfNotNull(operation, if_null);
        }
        static public J GetCustomAttributeOfTypeValue<J, T>(this IDynamicCustomAttributeProvider item, bool inherit, Operation<J, T> operation, Operation<J> if_null) where T : Attribute
        {
            return item.GetCustomAttributeOfType<T>(inherit).IfNotNull(operation, if_null);
        }
	}
}