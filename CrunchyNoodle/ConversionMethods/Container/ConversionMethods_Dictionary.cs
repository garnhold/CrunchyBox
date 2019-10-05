using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    [Conversion]
    static public class ConversionMethods_Dictionary
    {
        [Conversion]
        static public Dictionary<KEY_TYPE, VALUE_TYPE> ToDictionary<KEY_TYPE, VALUE_TYPE>(IEnumerable<KeyValuePair<KEY_TYPE, VALUE_TYPE>> pairs)
        {
            return pairs.ToDictionary();
        }

        [Conversion]
        static public Dictionary<KEY_TYPE, VALUE_TYPE> ToDictionary<KEY_TYPE, VALUE_TYPE>(IEnumerable<Tuple<KEY_TYPE, VALUE_TYPE>> pairs)
        {
            return pairs.ConvertToKeyValuePairs().ToDictionary();
        }
    }
}