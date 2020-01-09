using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Extract
    {
        static public IEnumerable<T> Extract<T>(this IList<T> item, Predicate<T> predicate)
        {
            List<T> extracted = new List<T>();

            item.RemoveAll(delegate(T sub_item) {
                if (predicate(sub_item))
                {
                    extracted.Add(sub_item);
                    return true;
                }

                return false;
            });

            return extracted;
        }
    }
}