using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ValueExtensions_Traverse
    {
        static public IEnumerable<T> Traverse<T>(this T item, Operation<T, T> operation)
        {
            return item.TraverseWithSelf(operation).Offset(1);
        }
        static public IEnumerable<T> TraverseWithSelf<T>(this T item, Operation<T, T> operation)
        {
            while (item != null)
            {
                yield return item;
                item = operation(item);
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