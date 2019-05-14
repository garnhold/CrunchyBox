using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class TypeExtensions_Generic
    {
        static public bool TryGetGenericArgument(this Type item, int index, out Type output)
        {
            return item.GetGenericArguments().TryGet(index, out output);
        }

        static public Type GetGenericArgument(this Type item, int index)
        {
            return item.GetGenericArguments().Get(index);
        }
    }
}