using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Apply
    {
        static public J Apply<T, J>(this IEnumerable<T> item, J input, Operation<J, J, T> operation)
        {
            item.Process(i => input = operation(input, i));
            return input;
        }
    }
}