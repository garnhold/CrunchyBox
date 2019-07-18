using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CrunchyDough
{
    static public class TypeExtensions_Treatment_Common
    {
        static public bool IsTypeType(this Type item)
        {
            if (item.CanBeTreatedAs<Type>())
                return true;

            return false;
        }
    }
}