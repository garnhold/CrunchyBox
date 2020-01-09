using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Crunchy.Dough
{
    static public class TypeExtensionsIEnumerable_AncestorType
    {
        static public Type GetCommonAncestor(this IEnumerable<Type> item)
        {
            return item.PerformIteratedBinaryOperation((t1, t2) => t1.GetCommonAncestor(t2));
        }
    }
}