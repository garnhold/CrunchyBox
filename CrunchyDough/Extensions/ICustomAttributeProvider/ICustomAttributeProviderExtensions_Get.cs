using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class ICustomAttributeProviderExtensions_Get
    {
		static public bool TryGetCustomAttributeOfType(this ICustomAttributeProvider item, Type attribute_type, bool inherit, out Attribute attribute)
		{
			return item.GetAllCustomAttributesOfType(attribute_type, inherit).TryGetFirst(out attribute);
		}
		static public Attribute GetCustomAttributeOfType(this ICustomAttributeProvider item, Type attribute_type, bool inherit)
        {
            Attribute attribute;

			item.TryGetCustomAttributeOfType(attribute_type, inherit, out attribute);
			return attribute;
        }

		static public bool TryGetCustomAttributeOfType<T>(this ICustomAttributeProvider item, bool inherit, out T attribute) where T : Attribute
        {
            return item.GetAllCustomAttributesOfType<T>(inherit).TryGetFirst(out attribute);
        }
        static public T GetCustomAttributeOfType<T>(this ICustomAttributeProvider item, bool inherit) where T : Attribute
        {
            T attribute;

			item.TryGetCustomAttributeOfType<T>(inherit, out attribute);
			return attribute;
        }

		static public bool TryGetCustomAttributeOfSubType<T>(this ICustomAttributeProvider item, Type attribute_type, bool inherit, out T attribute) where T : Attribute
        {
            return item.GetAllCustomAttributesOfSubType<T>(attribute_type, inherit).TryGetFirst(out attribute);
        }
        static public T GetCustomAttributeOfSubType<T>(this ICustomAttributeProvider item, Type attribute_type, bool inherit) where T : Attribute
        {
            T attribute;

			item.TryGetCustomAttributeOfSubType<T>(attribute_type, inherit, out attribute);
			return attribute;
        }
	}
	static public class IDynamicCustomAttributeProviderExtensions_Get
    {
		static public bool TryGetCustomAttributeOfType(this IDynamicCustomAttributeProvider item, Type attribute_type, bool inherit, out Attribute attribute)
		{
			return item.GetAllCustomAttributesOfType(attribute_type, inherit).TryGetFirst(out attribute);
		}
		static public Attribute GetCustomAttributeOfType(this IDynamicCustomAttributeProvider item, Type attribute_type, bool inherit)
        {
            Attribute attribute;

			item.TryGetCustomAttributeOfType(attribute_type, inherit, out attribute);
			return attribute;
        }

		static public bool TryGetCustomAttributeOfType<T>(this IDynamicCustomAttributeProvider item, bool inherit, out T attribute) where T : Attribute
        {
            return item.GetAllCustomAttributesOfType<T>(inherit).TryGetFirst(out attribute);
        }
        static public T GetCustomAttributeOfType<T>(this IDynamicCustomAttributeProvider item, bool inherit) where T : Attribute
        {
            T attribute;

			item.TryGetCustomAttributeOfType<T>(inherit, out attribute);
			return attribute;
        }

		static public bool TryGetCustomAttributeOfSubType<T>(this IDynamicCustomAttributeProvider item, Type attribute_type, bool inherit, out T attribute) where T : Attribute
        {
            return item.GetAllCustomAttributesOfSubType<T>(attribute_type, inherit).TryGetFirst(out attribute);
        }
        static public T GetCustomAttributeOfSubType<T>(this IDynamicCustomAttributeProvider item, Type attribute_type, bool inherit) where T : Attribute
        {
            T attribute;

			item.TryGetCustomAttributeOfSubType<T>(attribute_type, inherit, out attribute);
			return attribute;
        }
	}
}