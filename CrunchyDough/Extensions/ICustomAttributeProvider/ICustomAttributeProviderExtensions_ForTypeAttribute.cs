using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class ICustomAttributeProviderExtensions_ForTypeAttribute
    {
		static public bool HasCustomForTypeAttributeOfType(this ICustomAttributeProvider item, Type attribute_type, Type type)
        {
            return item.HasCustomAttributeOfSubType<ForTypeAttribute>(attribute_type, false, it => it.IsFor(type));
        }
        static public bool HasCustomForTypeAttributeOfType<T>(this ICustomAttributeProvider item, Type type) where T : ForTypeAttribute
        {
            return item.HasCustomForTypeAttributeOfType(typeof(T), type);
        }
	}
	static public class IDynamicCustomAttributeProviderExtensions_ForTypeAttribute
    {
		static public bool HasCustomForTypeAttributeOfType(this IDynamicCustomAttributeProvider item, Type attribute_type, Type type)
        {
            return item.HasCustomAttributeOfSubType<ForTypeAttribute>(attribute_type, false, it => it.IsFor(type));
        }
        static public bool HasCustomForTypeAttributeOfType<T>(this IDynamicCustomAttributeProvider item, Type type) where T : ForTypeAttribute
        {
            return item.HasCustomForTypeAttributeOfType(typeof(T), type);
        }
	}
}