using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Stutter
    {
        static public IEnumerable<T> Stutter<T>(this IEnumerable<T> item, Operation<int, T> operation)
        {
            foreach (T sub_item in item)
            {
                int copys = operation(sub_item);

                for (int i = 0; i < copys; i++)
                    yield return sub_item;
            }
        }

        static public IEnumerable<T> Stutter<T>(this IEnumerable<T> item, int copys)
        {
            return item.Stutter(i => copys);
        }

        static public IEnumerable<T> StutterByIndex<T>(this IEnumerable<T> item, Operation<int, int> operation)
        {
            int index = 0;

            return item.Stutter(i => operation(index++));
        }
    }
}