using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Crunchy.Dough
{
    static public class TypeExtensions_CleanName
    {
        static public string GetCleanName(this Type item)
        {
            if (item.IsGenericClass())
            {
                string base_name = item.GetBasicName();

                if (item.IsGenericTypedClass())
                     return base_name + "<" + item.GetGenericArguments().Convert(t => t.GetCleanName()).ToString(",") + ">";

                return base_name;
            }

            return item.Name;
        }

        static public bool IsCleanName(this Type item, string name)
        {
            if (item.GetCleanName() == name)
                return true;

            return false;
        }
    }
}