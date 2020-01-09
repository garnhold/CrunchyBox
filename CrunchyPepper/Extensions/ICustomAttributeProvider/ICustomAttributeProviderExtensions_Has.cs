using System;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;

namespace Crunchy.Pepper
{
    using Dough;
    
    static public class ICustomAttributeProviderExtensions_Has
    {
        static public bool HasCustomAttributeOfType(this ICustomAttributeProvider item, TypeReference type)
        {
            if(item.CustomAttributes.Has(a => type.AreEquivolent(a.AttributeType)))
                return true;

            return false;
        }

        static public bool HasCustomAttributeOfName(this ICustomAttributeProvider item, string name)
        {
            if (item.CustomAttributes.Has(a => a.AttributeType.Name == name))
                return true;

            return false;
        }
    }
}