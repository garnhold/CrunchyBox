using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Pad
    {
        static public IEnumerable<T> PadTo<T>(this IEnumerable<T> item, int target_length, Operation<T, int> operation)
        {
            int current_length = 0;

            foreach (T sub_item in item)
            {
                yield return sub_item;
                current_length++;
            }

            while (current_length < target_length)
            {
                yield return operation(current_length);
                current_length++;
            }
        }
        static public IEnumerable<T> PadTo<T>(this IEnumerable<T> item, int target_length, Operation<T> operation)
        {
            return item.PadTo(target_length, i => operation());
        }
        static public IEnumerable<T> PadTo<T>(this IEnumerable<T> item, int target_length, T value)
        {
            return item.PadTo(target_length, () => value);
        }
        static public IEnumerable<T> PadTo<T>(this IEnumerable<T> item, int target_length)
        {
            return item.PadTo(target_length, default(T));
        }
    }
}