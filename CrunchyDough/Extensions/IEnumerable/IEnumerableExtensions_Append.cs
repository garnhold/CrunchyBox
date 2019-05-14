using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Append
    {
        static public IEnumerable<T> Append<T>(this IEnumerable<T> item, IEnumerable<T> to_add)
        {
            if (item != null)
            {
                foreach(T sub_item in item)
                    yield return sub_item;
            }

            if(to_add != null)
            {
                foreach (T sub_to_add in to_add)
                    yield return sub_to_add;
            }
        }
        static public IEnumerable<T> Append<T>(this IEnumerable<T> item, params T[] to_add)
        {
            return item.Append<T>((IEnumerable<T>)to_add);
        }

        static public IEnumerable<T> Prepend<T>(this IEnumerable<T> item, IEnumerable<T> to_add)
        {
            return to_add.Append<T>(item);
        }
        static public IEnumerable<T> Prepend<T>(this IEnumerable<T> item, params T[] to_add)
        {
            return item.Prepend<T>((IEnumerable<T>)to_add);
        }
    }
}