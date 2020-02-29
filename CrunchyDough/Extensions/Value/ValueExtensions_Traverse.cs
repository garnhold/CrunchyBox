using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ValueExtensions_Traverse
    {
        static public IEnumerable<T> TraverseWithSelf<T>(this T item, Operation<T, T> operation)
        {
            while (item != null)
            {
                yield return item;
                item = operation(item);
            }
        }

        static public IEnumerable<J> Traverse<T, J>(this T item, Operation<J, T> operation) where J : T
        {
            J cast;

            while (item != null)
            {
                cast = operation(item);

                yield return cast;
                item = cast;
            }
        }

        static public IEnumerable<object> TraversePermissiveWithSelf<T>(this T item, Operation<object, T> operation)
        {
            return item.TraverseWithSelf<object>(delegate(object sub_item) {
                T cast;

                if (sub_item.Convert<T>(out cast))
                    return operation(cast);

                return null;
            });
        }
        static public IEnumerable<object> TraversePermissive<T>(this T item, Operation<object, T> operation)
        {
            return item.TraversePermissiveWithSelf(operation).Offset(1);
        }
    }
}