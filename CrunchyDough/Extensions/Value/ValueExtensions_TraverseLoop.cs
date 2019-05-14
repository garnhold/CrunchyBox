using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ValueExtensions_TraverseLoop
    {
        static private IEnumerable<T> TraverseLoop<T>(this T item, HashSet<T> set, Operation<T, T> operation)
        {
            T next_item = operation(item);

            if (next_item != null)
            {
                if (set.Add(next_item))
                    next_item.TraverseLoop(set, operation);
            }

            return set;
        }

        static public IEnumerable<T> TraverseLoop<T>(this T item, Operation<T, T> operation)
        {
            return item.TraverseLoop(new HashSet<T>(), operation);
        }

        static public IEnumerable<T> TraverseLoopWithSelf<T>(this T item, Operation<T, T> operation)
        {
            return item.TraverseLoop(operation).Prepend(item);
        }
    }
}