using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_ProcessWithIndex
    {
        static public int ProcessWithIndex<T>(this IEnumerable<T> item, Process<int, T> process)
        {
            int index = 0;

            if (item != null)
            {
                foreach (T sub_item in item)
                    process(index++, sub_item);
            }

            return index;
        }
        static public int ProcessWithIndex<T>(this IEnumerable<T> item, Process<int, T> process_first, Process<int, T> process_remaining)
        {
            int index = 0;

            if (item != null)
            {
                using (IEnumerator<T> iterator = item.GetEnumerator())
                {
                    if (iterator.MoveNext())
                    {
                        process_first(index++, iterator.Current);

                        while (iterator.MoveNext())
                            process_remaining(index++, iterator.Current);
                    }
                }
            }

            return index;
        }
    }
}