using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Unwrap
    {
        static public IEnumerable<object> Unwrap<J, T>(this IEnumerable<J> item, Operation<object, T> operation)
        {
            foreach (J sub_item in item)
            {
                T cast;

                if (sub_item.Convert<T>(out cast))
                    yield return operation(cast);
                else
                    yield return sub_item;
            }
        }

        static public IEnumerable<object> Unwrap<J, T>(this IEnumerable<J> item, Operation<IEnumerable<object>, T> operation)
        {
            foreach (J sub_item in item)
            {
                T cast;

                if (sub_item.Convert<T>(out cast))
                {
                    foreach (object sub_sub_item in operation(cast))
                        yield return sub_sub_item;
                }
                else
                {
                    yield return sub_item;
                }
            }
        }

    }
}