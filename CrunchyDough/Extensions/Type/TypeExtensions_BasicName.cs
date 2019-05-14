using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CrunchyDough
{
    static public class TypeExtensions_BasicName
    {
        static public string GetBasicName(this Type item)
        {
            return item.Name.Truncate(item.Name.FindIndexOf("`"));
        }

        static public bool IsBasicName(this Type item, string name)
        {
            if (item.GetBasicName() == name)
                return true;

            return false;
        }
    }
}