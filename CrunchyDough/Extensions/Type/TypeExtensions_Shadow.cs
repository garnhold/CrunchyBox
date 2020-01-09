using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class TypeExtensions_Shadow
    {
        static public bool IsShadowedBy(this Type item, Type type)
        {
            if (item.IsParentOf(type))
                return true;

            return false;
        }
        static public bool IsNotShadowedBy(this Type item, Type type)
        {
            if (item.IsShadowedBy(type) == false)
                return true;

            return false;
        }
        static public int DetermineShadowing(this Type item, Type type)
        {
            if (item.IsShadowedBy(type))
                return 1;

            if (type.IsShadowedBy(item))
                return -1;

            return 0;
        }

        static public bool IsShadowedByAny(this Type item, IEnumerable<Type> types)
        {
            if (types.Has(it => item.IsShadowedBy(it)))
                return true;

            return false;
        }
        static public bool IsNotShadowedByAny(this Type item, IEnumerable<Type> types)
        {
            if (item.IsShadowedByAny(types) == false)
                return true;

            return false;
        }
    }
}