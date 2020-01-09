using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Convert_KeyValuePair
    {
        static public IEnumerable<KeyValuePair<KEY_TYPE, VALUE_TYPE>> ConvertToValueOfPair<KEY_TYPE, VALUE_TYPE>(this IEnumerable<VALUE_TYPE> item, Operation<KEY_TYPE, VALUE_TYPE> operation)
        {
            return item.Convert(i => KeyValuePair.New(operation(i), i));
        }

        static public IEnumerable<KeyValuePair<KEY_TYPE, VALUE_TYPE>> ConvertToKeyOfPair<KEY_TYPE, VALUE_TYPE>(this IEnumerable<KEY_TYPE> item, Operation<VALUE_TYPE, KEY_TYPE> operation)
        {
            return item.Convert(i => KeyValuePair.New(i, operation(i)));
        }

        static public IEnumerable<KeyValuePair<T, int>> ConvertToKeyOfIndexedPair<T>(this IEnumerable<T> item)
        {
            return item.ConvertWithIndex((i, v) => KeyValuePair.New(v, i));
        }

        static public IEnumerable<KeyValuePair<int, T>> ConvertToValueOfIndexedPair<T>(this IEnumerable<T> item)
        {
            return item.ConvertWithIndex((i, v) => KeyValuePair.New(i, v));
        }

        static public IEnumerable<KeyValuePair<OUTPUT_KEY_TYPE, VALUE_TYPE>> ConvertKeysOfPair<INPUT_KEY_TYPE, VALUE_TYPE, OUTPUT_KEY_TYPE>(this IEnumerable<KeyValuePair<INPUT_KEY_TYPE, VALUE_TYPE>> item, Operation<OUTPUT_KEY_TYPE, INPUT_KEY_TYPE> operation)
        {
            return item.Convert(p => KeyValuePair.New(operation(p.Key), p.Value));
        }

        static public IEnumerable<KeyValuePair<KEY_TYPE, OUTPUT_VALUE_TYPE>> ConvertValuesOfPair<KEY_TYPE, INPUT_VALUE_TYPE, OUTPUT_VALUE_TYPE>(this IEnumerable<KeyValuePair<KEY_TYPE, INPUT_VALUE_TYPE>> item, Operation<OUTPUT_VALUE_TYPE, INPUT_VALUE_TYPE> operation)
        {
            return item.Convert(p => KeyValuePair.New(p.Key, operation(p.Value)));
        }
    }
}