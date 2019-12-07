using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Crunchy.Dough
{
    static public class TypeExtensions_Constructor
    {
        static public ConstructorInfo GetDefaultConstructor(this Type item)
        {
            return item.GetConstructor(EmptyArray<Type>.INSTANCE);
        }
    }
}