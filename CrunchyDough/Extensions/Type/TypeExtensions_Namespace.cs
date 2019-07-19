using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CrunchyDough
{
    static public class TypeExtensions_Namespace
    {
        static public string GetNamespace(this Type item)
        {
            return item.Namespace;
        }

        static public bool HasNamespace(this Type item)
        {
            if (item.GetNamespace().IsVisible())
                return true;

            return false;
        }

        static public bool IsNamespace(this Type item, string name)
        {
            if (item.GetNamespace() == name)
                return true;

            return false;
        }
    }
}