using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class ICustomAttributeProviderExtensions_ForTypeAttribute
    {
        static public bool TryGetCustomForTypeAttributeOfTypeTypeDistance(this ICustomAttributeProvider item, Type attribute_type, Type type, out int distance)
        {
            ForTypeAttribute attribute = item.GetCustomAttributeOfSubType<ForTypeAttribute>(attribute_type, false);

            if (attribute != null)
            {
                distance = attribute.GetTypeDistance(type);
                return true;
            }

            distance = int.MaxValue;
            return false;
        }
        static public bool TryGetCustomForTypeAttributeOfTypeTypeDistance<T>(this ICustomAttributeProvider item, Type type, out int distance)
        {
            return item.TryGetCustomForTypeAttributeOfTypeTypeDistance(typeof(T), type, out distance);
        }

        static public int GetCustomForTypeAttributeOfTypeTypeDistance(this ICustomAttributeProvider item, Type attribute_type, Type type)
        {
            int distance;

            item.TryGetCustomForTypeAttributeOfTypeTypeDistance(attribute_type, type, out distance);
            return distance;
        }
        static public int GetCustomForTypeAttributeOfTypeTypeDistance<T>(this ICustomAttributeProvider item, Type type)
        {
            return item.GetCustomForTypeAttributeOfTypeTypeDistance(typeof(T), type);
        }
    }
}