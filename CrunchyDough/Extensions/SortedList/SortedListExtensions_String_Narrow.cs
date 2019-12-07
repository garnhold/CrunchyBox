using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class SortedListExtensions_String_Narrow
    {
        static public IEnumerable<KeyValuePair<string, VALUE_TYPE>> NarrowStartsWith<VALUE_TYPE>(this SortedList<string, VALUE_TYPE> item, string prefix)
        {
            bool has_started = false;

            for (int i = item.FindNearestIndexByKey(prefix, BoundType.Below); i < item.Count; i++)
            {
                string key = item.Keys[i];
                VALUE_TYPE value = item.Values[i];

                if (has_started && key.StartsWith(prefix) == false)
                    yield break;

                yield return KeyValuePair.New(key, value);
                has_started = true;
            }
        }
    }
}