using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_To_SortedList
    {
        static public SortedList<KEY_TYPE, VALUE_TYPE> ToSortedList<KEY_TYPE, VALUE_TYPE>(this IEnumerable<KeyValuePair<KEY_TYPE, VALUE_TYPE>> item)
        {
            SortedList<KEY_TYPE, VALUE_TYPE> sorted_list = new SortedList<KEY_TYPE, VALUE_TYPE>();

            sorted_list.AddRange(item);
            return sorted_list;
        }

        static public SortedList<KEY_TYPE, VALUE_TYPE> ToSortedListValues<KEY_TYPE, VALUE_TYPE>(this IEnumerable<VALUE_TYPE> item, Operation<KEY_TYPE, VALUE_TYPE> operation)
        {
            return item.ConvertToValueOfPair(operation).ToSortedList();
        }
        static public SortedList<KEY_TYPE, VALUE_TYPE> ToSortedListKeys<KEY_TYPE, VALUE_TYPE>(this IEnumerable<KEY_TYPE> item, Operation<VALUE_TYPE, KEY_TYPE> operation)
        {
            return item.ConvertToKeyOfPair(operation).ToSortedList();
        }
    }
}