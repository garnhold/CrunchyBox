using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Perform
    {
        static public T PerformIteratedBinaryOperation<T>(this IEnumerable<T> item, Operation<T, T, T> operation, out int count)
        {
            T value = default(T);

            count = item.ProcessAndCount(i => value = i, i => value = operation(value, i));
            return value;
        }

        static public T PerformIteratedBinaryOperation<T>(this IEnumerable<T> item, Operation<T, T, T> operation)
        {
            int count;

            return item.PerformIteratedBinaryOperation(operation, out count);
        }
    }
}