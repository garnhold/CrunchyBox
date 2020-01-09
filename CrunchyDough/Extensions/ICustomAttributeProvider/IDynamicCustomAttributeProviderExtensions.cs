using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Crunchy.Dough
{
    static public class IDynamicCustomAttributeProviderExtensions
    {
        static public IEnumerable<Attribute> GetAllCustomAttributesOfType(this IDynamicCustomAttributeProvider item, Type attribute_type, bool inherit)
        {
            return item.GetAllCustomAttributes(inherit).Narrow(a => a.CanObjectBeTreatedAs(attribute_type));
        }

        static public IEnumerable<T> GetAllCustomAttributesOfType<T>(this IDynamicCustomAttributeProvider item, bool inherit) where T : Attribute
        {
            return item.GetAllCustomAttributesOfType(typeof(T), inherit).Convert<Attribute, T>();
        }

        static public IEnumerable<T> GetAllCustomAttributesOfSubType<T>(this IDynamicCustomAttributeProvider item, Type attribute_type, bool inherit) where T : Attribute
        {
            return GetAllCustomAttributesOfType<T>(item, inherit).Narrow(a => a.CanObjectBeTreatedAs(attribute_type));
        }

        static public bool HasCustomAttributeOfType(this IDynamicCustomAttributeProvider item, Type attribute_type, bool inherit)
        {
            if (item.GetCustomAttributeOfType(attribute_type, inherit) != null)
                return true;

            return false;
        }
    }
}