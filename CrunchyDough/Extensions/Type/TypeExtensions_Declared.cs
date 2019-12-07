using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Crunchy.Dough
{
    static public class TypeExtensions_Declared
    {
        static public bool IsDeclaredWithin(this Type item, Assembly assembly)
        {
            if (item.Assembly == assembly)
                return true;

            return false;
        }
    }
}