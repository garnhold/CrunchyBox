using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IDictionaryExtensions_Composite
    {
        static public void Add<KEY_TYPE1, KEY_TYPE2, VALUE_TYPE>(this IDictionary<KEY_TYPE1, Dictionary<KEY_TYPE2, VALUE_TYPE>> item, KEY_TYPE1 key1, KEY_TYPE2 key2, VALUE_TYPE value)
        {
            item.GetOrCreateDefaultValue(key1).Add(key2, value);
        }

        static public bool TryGetValue<KEY_TYPE1, KEY_TYPE2, VALUE_TYPE>(this IDictionary<KEY_TYPE1, Dictionary<KEY_TYPE2, VALUE_TYPE>> item, KEY_TYPE1 key1, KEY_TYPE2 key2, out VALUE_TYPE value)
        {
            Dictionary<KEY_TYPE2, VALUE_TYPE> dictionary;

            if (item.TryGetValue(key1, out dictionary))
                return dictionary.TryGetValue(key2, out value);

            value = default(VALUE_TYPE);
            return false;
        }

        static public VALUE_TYPE GetValue<KEY_TYPE1, KEY_TYPE2, VALUE_TYPE>(this IDictionary<KEY_TYPE1, Dictionary<KEY_TYPE2, VALUE_TYPE>> item, KEY_TYPE1 key1, KEY_TYPE2 key2, VALUE_TYPE default_value)
        {
            VALUE_TYPE value;

            if (item.TryGetValue(key1, key2, out value))
                return value;

            return default_value;
        }
        static public VALUE_TYPE GetValue<KEY_TYPE1, KEY_TYPE2, VALUE_TYPE>(this IDictionary<KEY_TYPE1, Dictionary<KEY_TYPE2, VALUE_TYPE>> item, KEY_TYPE1 key1, KEY_TYPE2 key2)
        {
            return item.GetValue(key1, key2, default(VALUE_TYPE));
        }

        static public IDictionary<KEY_TYPE2, VALUE_TYPE> GetDictionary<KEY_TYPE1, KEY_TYPE2, VALUE_TYPE>(this IDictionary<KEY_TYPE1, Dictionary<KEY_TYPE2, VALUE_TYPE>> item, KEY_TYPE1 key1)
        {
            Dictionary<KEY_TYPE2, VALUE_TYPE> dictionary;

            if (item.TryGetValue(key1, out dictionary))
                return dictionary;

            return Empty.IDictionary<KEY_TYPE2, VALUE_TYPE>();
        }
        static public IEnumerable<VALUE_TYPE> GetValues<KEY_TYPE1, KEY_TYPE2, VALUE_TYPE>(this IDictionary<KEY_TYPE1, Dictionary<KEY_TYPE2, VALUE_TYPE>> item, KEY_TYPE1 key1)
        {
            return item.GetDictionary(key1).Values;
        }
    }
}