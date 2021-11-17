using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_To_Dictionary
    {
        static public Dictionary<KEY_TYPE, VALUE_TYPE> ToDictionary<KEY_TYPE, VALUE_TYPE>(this IEnumerable<KeyValuePair<KEY_TYPE, VALUE_TYPE>> item)
        {
            Dictionary<KEY_TYPE, VALUE_TYPE> dictionary = new Dictionary<KEY_TYPE, VALUE_TYPE>();

            dictionary.AddRange(item);
            return dictionary;
        }
        static public Dictionary<KEY_TYPE, VALUE_TYPE> ToDictionarySkip<KEY_TYPE, VALUE_TYPE>(this IEnumerable<KeyValuePair<KEY_TYPE, VALUE_TYPE>> item)
        {
            Dictionary<KEY_TYPE, VALUE_TYPE> dictionary = new Dictionary<KEY_TYPE, VALUE_TYPE>();

            dictionary.SetRangeSkip(item);
            return dictionary;
        }
        static public Dictionary<KEY_TYPE, VALUE_TYPE> ToDictionaryOverwrite<KEY_TYPE, VALUE_TYPE>(this IEnumerable<KeyValuePair<KEY_TYPE, VALUE_TYPE>> item)
        {
            Dictionary<KEY_TYPE, VALUE_TYPE> dictionary = new Dictionary<KEY_TYPE, VALUE_TYPE>();

            dictionary.SetRangeOverwrite(item);
            return dictionary;
        }

        static public Dictionary<KEY_TYPE, VALUE_TYPE> ToDictionaryValues<KEY_TYPE, VALUE_TYPE>(this IEnumerable<VALUE_TYPE> item, Operation<KEY_TYPE, VALUE_TYPE> operation)
        {
            return item.ConvertToValueOfPair(operation).ToDictionary();
        }
        static public Dictionary<KEY_TYPE, VALUE_TYPE> ToDictionarySkipValues<KEY_TYPE, VALUE_TYPE>(this IEnumerable<VALUE_TYPE> item, Operation<KEY_TYPE, VALUE_TYPE> operation)
        {
            return item.ConvertToValueOfPair(operation).ToDictionarySkip();
        }
        static public Dictionary<KEY_TYPE, VALUE_TYPE> ToDictionaryOverwriteValues<KEY_TYPE, VALUE_TYPE>(this IEnumerable<VALUE_TYPE> item, Operation<KEY_TYPE, VALUE_TYPE> operation)
        {
            return item.ConvertToValueOfPair(operation).ToDictionaryOverwrite();
        }

        static public Dictionary<KEY_TYPE, VALUE_TYPE> ToDictionaryKeys<KEY_TYPE, VALUE_TYPE>(this IEnumerable<KEY_TYPE> item, Operation<VALUE_TYPE, KEY_TYPE> operation)
        {
            return item.ConvertToKeyOfPair(operation).ToDictionary();
        }
        static public Dictionary<KEY_TYPE, VALUE_TYPE> ToDictionarySkipKeys<KEY_TYPE, VALUE_TYPE>(this IEnumerable<KEY_TYPE> item, Operation<VALUE_TYPE, KEY_TYPE> operation)
        {
            return item.ConvertToKeyOfPair(operation).ToDictionarySkip();
        }
        static public Dictionary<KEY_TYPE, VALUE_TYPE> ToDictionaryOverwriteKeys<KEY_TYPE, VALUE_TYPE>(this IEnumerable<KEY_TYPE> item, Operation<VALUE_TYPE, KEY_TYPE> operation)
        {
            return item.ConvertToKeyOfPair(operation).ToDictionaryOverwrite();
        }

        static public Dictionary<KEY_TYPE, List<VALUE_TYPE>> ToMultiDictionary<KEY_TYPE, VALUE_TYPE>(this IEnumerable<KeyValuePair<KEY_TYPE, VALUE_TYPE>> item)
        {
            Dictionary<KEY_TYPE, List<VALUE_TYPE>> dictionary = new Dictionary<KEY_TYPE, List<VALUE_TYPE>>();

            item.Process(i => dictionary.Add(i.Key, i.Value));
            return dictionary;
        }

        static public Dictionary<KEY_TYPE, List<VALUE_TYPE>> ToMultiDictionary<KEY_TYPE, VALUE_TYPE>(this IEnumerable<VALUE_TYPE> item, Operation<KEY_TYPE, VALUE_TYPE> operation)
        {
            Dictionary<KEY_TYPE, List<VALUE_TYPE>> dictionary = new Dictionary<KEY_TYPE, List<VALUE_TYPE>>();

            item.Process(i => dictionary.Add(operation(i), i));
            return dictionary;
        }
    }
}