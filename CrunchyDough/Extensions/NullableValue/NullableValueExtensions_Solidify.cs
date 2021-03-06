using System;
using System.Reflection;

namespace Crunchy.Dough
{
    static public class NullableValueExtensions_Solidify
    {
        static public T Solidify<T>(this T? item) where T : struct
        {
            if (item == null)
                return default(T);

            return (T)item;
        }
    }
}