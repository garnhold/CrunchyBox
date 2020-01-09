using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Branch
    {
        static public void Branch<T>(this IEnumerable<T> item, Predicate<T> predicate, Process<T> true_process, Process<T> false_process)
        {
            foreach (T sub_item in item)
            {
                if (predicate(sub_item))
                    true_process(sub_item);
                else
                    false_process(sub_item);
            }
        }
    }
}