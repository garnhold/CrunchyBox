using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CrunchyDough
{
    static public class ICustomAttributeProviderExtensions_Internal<ATTRIBUTE_TYPE> where ATTRIBUTE_TYPE : Attribute
    {
        static private OperationCache<List<ATTRIBUTE_TYPE>, ICustomAttributeProvider, bool> GET_ALL_CUSTOM_ATTRIBUTES_OF_TYPE = ReflectionCache.Get().NewOperationCache(delegate(ICustomAttributeProvider item, bool inherit) {
            return item.GetAllCustomAttributesOfType(typeof(ATTRIBUTE_TYPE), inherit)
                .Convert<Attribute, ATTRIBUTE_TYPE>()
                .ToList();
        });
        static public IEnumerable<ATTRIBUTE_TYPE> GetAllCustomAttributesOfType(ICustomAttributeProvider item, bool inherit)
        {
            return GET_ALL_CUSTOM_ATTRIBUTES_OF_TYPE.Fetch(item, inherit);
        }

        static private OperationCache<List<ATTRIBUTE_TYPE>, ICustomAttributeProvider, Type, bool> GET_ALL_CUSTOM_ATTRIBUTES_OF_SUB_TYPE = ReflectionCache.Get().NewOperationCache(delegate(ICustomAttributeProvider item, Type attribute_type, bool inherit) {
            return GetAllCustomAttributesOfType(item, inherit)
                .Narrow(a => a.CanObjectBeTreatedAs(attribute_type))
                .ToList();
        });
        static public IEnumerable<ATTRIBUTE_TYPE> GetAllCustomAttributesOfSubType(ICustomAttributeProvider item, Type attribute_type, bool inherit)
        {
            return GET_ALL_CUSTOM_ATTRIBUTES_OF_SUB_TYPE.Fetch(item, attribute_type, inherit);
        }
    }
}