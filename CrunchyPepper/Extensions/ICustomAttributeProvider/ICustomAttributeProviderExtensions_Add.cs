using System;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;

using CrunchyDough;

namespace CrunchyPepper
{
    static public class ICustomAttributeProviderExtensions_Add
    {
        static public CustomAttribute AddCustomAttribute(this ICustomAttributeProvider item, CustomAttribute attribute)
        {
            return item.CustomAttributes.AddAndGet(attribute);
        }

        static public CustomAttribute AddCustomAttributeWithConstructor(this ICustomAttributeProvider item, MethodReference method)
        {
            return item.AddCustomAttribute(new CustomAttribute(method));
        }
    }
}