using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ValueExtensions_TraverseWeb
    {
        static public IEnumerable<T> TraverseWeb<T>(this T item, Operation<IEnumerable<T>, T> operation, int remaining_depth, HashSet<T> set)
        {
            if (remaining_depth > 0)
            {
                int new_remaining_depth = remaining_depth - 1;

                foreach (T sub_item in operation(item))
                {
                    if (sub_item != null)
                    {
                        if (set.Add(sub_item))
                        {
                            yield return sub_item;

                            foreach (T sub_sub_item in sub_item.TraverseWeb<T>(operation, new_remaining_depth, set))
                                yield return sub_sub_item;
                        }
                    }
                }
            }
        }

        static public IEnumerable<T> TraverseWeb<T>(this T item, Operation<IEnumerable<T>, T> operation, int max_depth)
        {
            return item.TraverseWeb(operation, max_depth, new HashSet<T>());
        }
        static public IEnumerable<T> TraverseWeb<T>(this T item, Operation<IEnumerable<T>, T> operation)
        {
            return item.TraverseWeb(operation, int.MaxValue);
        }

        static public IEnumerable<T> TraverseWebWithSelf<T>(this T item, Operation<IEnumerable<T>, T> operation, int max_depth)
        {
            HashSet<T> set = new HashSet<T>();

            set.Add(item);
            return item.TraverseWeb(operation, max_depth, set).Prepend(item);
        }
        static public IEnumerable<T> TraverseWebWithSelf<T>(this T item, Operation<IEnumerable<T>, T> operation)
        {
            return item.TraverseWebWithSelf(operation, int.MaxValue);
        }
    }
}