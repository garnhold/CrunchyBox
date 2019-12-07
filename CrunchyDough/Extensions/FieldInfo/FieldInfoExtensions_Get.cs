using System;
using System.Reflection;

namespace Crunchy.Dough
{
    static public class FieldInfoExtensions_Get
    {
        static public bool TryGetValue<T>(this FieldInfo item, object obj, out T value)
        {
            return item.GetValue(obj).Convert<T>(out value);
        }

        static public T GetValue<T>(this FieldInfo item, object obj)
        {
            T value;

            item.TryGetValue<T>(obj, out value);
            return value;
        }
    }
}