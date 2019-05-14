using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
	static public class ICustomAttributeProviderExtensions_Has
    {
		static public bool HasCustomAttributeOfType<T>(this ICustomAttributeProvider item, bool inherit) where T : Attribute
        {
            return item.HasCustomAttributeOfType(typeof(T), inherit);
        }

		static public bool HasCustomAttribute(this ICustomAttributeProvider item, bool inherit, Predicate<Attribute> predicate)
        {
            if (item.FindCustomAttribute(inherit, predicate) != null)
                return true;

            return false;
        }

        static public bool HasCustomAttributeOfType(this ICustomAttributeProvider item, Type attribute_type, bool inherit, Predicate<Attribute> predicate)
        {
			if (item.FindCustomAttributeOfType(attribute_type, inherit, predicate) != null)
				return true;

            return false;
        }
        static public bool HasCustomAttributeOfType<T>(this ICustomAttributeProvider item, bool inherit, Predicate<T> predicate) where T : Attribute
        {
            if (item.FindCustomAttributeOfType<T>(inherit, predicate) != null)
                return true;

            return false;
        }

        static public bool HasCustomAttributeOfSubType<T>(this ICustomAttributeProvider item, Type attribute_type, bool inherit, Predicate<T> predicate) where T : Attribute
        {
            if (item.FindCustomAttributeOfSubType<T>(attribute_type, inherit, predicate) != null)
                return true;

            return false;
        }
	}
	static public class IDynamicCustomAttributeProviderExtensions_Has
    {
		static public bool HasCustomAttributeOfType<T>(this IDynamicCustomAttributeProvider item, bool inherit) where T : Attribute
        {
            return item.HasCustomAttributeOfType(typeof(T), inherit);
        }

		static public bool HasCustomAttribute(this IDynamicCustomAttributeProvider item, bool inherit, Predicate<Attribute> predicate)
        {
            if (item.FindCustomAttribute(inherit, predicate) != null)
                return true;

            return false;
        }

        static public bool HasCustomAttributeOfType(this IDynamicCustomAttributeProvider item, Type attribute_type, bool inherit, Predicate<Attribute> predicate)
        {
			if (item.FindCustomAttributeOfType(attribute_type, inherit, predicate) != null)
				return true;

            return false;
        }
        static public bool HasCustomAttributeOfType<T>(this IDynamicCustomAttributeProvider item, bool inherit, Predicate<T> predicate) where T : Attribute
        {
            if (item.FindCustomAttributeOfType<T>(inherit, predicate) != null)
                return true;

            return false;
        }

        static public bool HasCustomAttributeOfSubType<T>(this IDynamicCustomAttributeProvider item, Type attribute_type, bool inherit, Predicate<T> predicate) where T : Attribute
        {
            if (item.FindCustomAttributeOfSubType<T>(attribute_type, inherit, predicate) != null)
                return true;

            return false;
        }
	}
}