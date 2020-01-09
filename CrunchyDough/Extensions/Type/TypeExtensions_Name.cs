using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Crunchy.Dough
{
    static public class TypeExtensions_Name
    {
        static public bool IsNamed(this Type item, string name)
        {
            if (item.Name == name)
                return true;

            return false;
        }

        static public bool IsNamedTheSame(this Type item, Type type)
        {
            if (item.IsNamed(type.Name))
                return true;

            return false;
        }

        static public bool DoesNameContain(this Type item, string needle)
        {
            if (item.Name.Contains(needle))
                return true;

            return false;
        }

        static public bool DoesNameStartWith(this Type item, string needle)
        {
            if (item.Name.StartsWith(needle))
                return true;

            return false;
        }
    }
}