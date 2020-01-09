using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Expand
    {
        static public IEnumerable<object> Expand<J, T>(this IEnumerable<J> item, Operation<object, T> operation)
        {
            foreach (J sub_item in item)
            {
                T cast;

                yield return sub_item;
                if (sub_item.Convert<T>(out cast))
                    yield return operation(cast);
            }
        }

        static public IEnumerable<object> Expand<J, T>(this IEnumerable<J> item, Operation<IEnumerable<object>, T> operation)
        {
            foreach (J sub_item in item)
            {
                T cast;

                yield return sub_item;
                if (sub_item.Convert<T>(out cast))
                {
                    foreach (object sub_sub_item in operation(cast))
                        yield return sub_sub_item;
                }
            }
        }

        static public IEnumerable<T> Expand<T>(this IEnumerable<T> item, Operation<T, T> operation)
        {
            foreach (T sub_item in item)
            {
                yield return sub_item;
                yield return operation(sub_item);
            }
        }
    }
}