using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CrunchyDough
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