using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Search_FindType
    {
        static public bool TryFindFirstOfType<T>(this IEnumerable<T> item, Type type, out T value)
        {
            return item.TryFindFirst(i => i.CanObjectBeTreatedAs(type), out value);
        }
        static public T FindFirstOfType<T>(this IEnumerable<T> item, Type type)
        {
            T value;

            item.TryFindFirstOfType(type, out value);
            return value;
        }

        static public bool TryFindFirstOfType<T, J>(this IEnumerable<T> item, out J value)
        {
            T temp;
            bool to_return = item.TryFindFirstOfType(typeof(J), out temp);

            value = temp.Convert<J>();
            return to_return;
        }
        static public J FindFirstOfType<T, J>(this IEnumerable<T> item)
        {
            J value;

            item.TryFindFirstOfType(out value);
            return value;
        }
        
    }
}