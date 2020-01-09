using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Crunchy.Dough
{
    static public class TypeExtensions_AncestorType
    {
        static public Type GetCommonAncestor(this Type item, Type other)
        {
            return item.GetTypeAndAllBaseTypes().FindFirst(t => other.CanBeTreatedAs(t));
        }
    }
}