using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class ICustomAttributeProviderExtensions_Search
    {
		static public Attribute FindCustomAttribute(this ICustomAttributeProvider item, bool inherit, Predicate<Attribute> predicate)
        {
            return item.GetAllCustomAttributes(inherit).FindFirst(predicate);
        }

        static public Attribute FindCustomAttributeOfType(this ICustomAttributeProvider item, Type attribute_type, bool inherit, Predicate<Attribute> predicate)
        {
            return item.GetAllCustomAttributesOfType(attribute_type, inherit).FindFirst(predicate);
        }

        static public T FindCustomAttributeOfType<T>(this ICustomAttributeProvider item, bool inherit, Predicate<T> predicate) where T : Attribute
        {
            return item.GetAllCustomAttributesOfType<T>(inherit).FindFirst(predicate);
        }

        static public T FindCustomAttributeOfSubType<T>(this ICustomAttributeProvider item, Type attribute_type, bool inherit, Predicate<T> predicate) where T : Attribute
        {
            return item.GetAllCustomAttributesOfSubType<T>(attribute_type, inherit).FindFirst(predicate);
        }
	}
	static public class IDynamicCustomAttributeProviderExtensions_Search
    {
		static public Attribute FindCustomAttribute(this IDynamicCustomAttributeProvider item, bool inherit, Predicate<Attribute> predicate)
        {
            return item.GetAllCustomAttributes(inherit).FindFirst(predicate);
        }

        static public Attribute FindCustomAttributeOfType(this IDynamicCustomAttributeProvider item, Type attribute_type, bool inherit, Predicate<Attribute> predicate)
        {
            return item.GetAllCustomAttributesOfType(attribute_type, inherit).FindFirst(predicate);
        }

        static public T FindCustomAttributeOfType<T>(this IDynamicCustomAttributeProvider item, bool inherit, Predicate<T> predicate) where T : Attribute
        {
            return item.GetAllCustomAttributesOfType<T>(inherit).FindFirst(predicate);
        }

        static public T FindCustomAttributeOfSubType<T>(this IDynamicCustomAttributeProvider item, Type attribute_type, bool inherit, Predicate<T> predicate) where T : Attribute
        {
            return item.GetAllCustomAttributesOfSubType<T>(attribute_type, inherit).FindFirst(predicate);
        }
	}
}