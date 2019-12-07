using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Crunchy.Dough
{
    static public class ICustomAttributeProviderExtensions
    {
        static private OperationCache<List<Attribute>, ICustomAttributeProvider, bool> GET_ALL_CUSTOM_ATTRIBUTES = ReflectionCache.Get().NewOperationCache("GET_ALL_CUSTOM_ATTRIBUTES", delegate(ICustomAttributeProvider item, bool inherit) {
            return item.GetCustomAttributes(inherit)
                .Convert<object, Attribute>()
                .ToList();
        });
        static public IEnumerable<Attribute> GetAllCustomAttributes(this ICustomAttributeProvider item, bool inherit)
        {
            return GET_ALL_CUSTOM_ATTRIBUTES.Fetch(item, inherit);
        }

        static private OperationCache<List<Attribute>, ICustomAttributeProvider, Type, bool> GET_ALL_CUSTOM_ATTRIBUTES_OF_TYPE = ReflectionCache.Get().NewOperationCache("GET_ALL_CUSTOM_ATTRIBUTES_OF_TYPE", delegate(ICustomAttributeProvider item, Type attribute_type, bool inherit) {
            return item.GetAllCustomAttributes(inherit)
                .Narrow(a => a.CanObjectBeTreatedAs(attribute_type))
                .ToList();
        });
        static public IEnumerable<Attribute> GetAllCustomAttributesOfType(this ICustomAttributeProvider item, Type attribute_type, bool inherit)
        {
            return GET_ALL_CUSTOM_ATTRIBUTES_OF_TYPE.Fetch(item, attribute_type, inherit);
        }

        static public IEnumerable<T> GetAllCustomAttributesOfType<T>(this ICustomAttributeProvider item, bool inherit) where T : Attribute
        {
            return ICustomAttributeProviderExtensions_Internal<T>.GetAllCustomAttributesOfType(item, inherit);
        }

        static public IEnumerable<T> GetAllCustomAttributesOfSubType<T>(this ICustomAttributeProvider item, Type attribute_type, bool inherit) where T : Attribute
        {
            return ICustomAttributeProviderExtensions_Internal<T>.GetAllCustomAttributesOfSubType(item, attribute_type, inherit);
        }

        static public bool HasCustomAttributeOfType(this ICustomAttributeProvider item, Type attribute_type, bool inherit)
        {
            if (item.IsDefined(attribute_type, inherit))
                return true;

            return false;
        }
    }
}