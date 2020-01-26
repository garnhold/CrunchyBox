using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IDictionaryExtensions_HashSet
    {
        static public void Add<KEY_TYPE, VALUE_TYPE>(this IDictionary<KEY_TYPE, HashSet<VALUE_TYPE>> item, KEY_TYPE key, VALUE_TYPE value)
        {
            item.GetOrCreateDefaultValue(key).Add(value);
        }

        static public void AddRange<KEY_TYPE, VALUE_TYPE>(this IDictionary<KEY_TYPE, HashSet<VALUE_TYPE>> item, IEnumerable<KeyValuePair<KEY_TYPE, VALUE_TYPE>> pairs)
        {
            pairs.Process(p => item.Add(p.Key, p.Value));
        }
        static public void AddRange<KEY_TYPE, VALUE_TYPE>(this IDictionary<KEY_TYPE, HashSet<VALUE_TYPE>> item, params KeyValuePair<KEY_TYPE, VALUE_TYPE>[] pairs)
        {
            item.AddRange((IEnumerable<KeyValuePair<KEY_TYPE, VALUE_TYPE>>)pairs);
        }

        static public IEnumerable<VALUE_TYPE> GetValues<KEY_TYPE, VALUE_TYPE>(this IDictionary<KEY_TYPE, HashSet<VALUE_TYPE>> item, KEY_TYPE key)
        {
            HashSet<VALUE_TYPE> list;

            if (item.TryGetValue(key, out list))
                return list;

            return Empty.IEnumerable<VALUE_TYPE>();
        }

        static public IEnumerable<VALUE_TYPE> GetAllAtKeys<KEY_TYPE, VALUE_TYPE>(this IDictionary<KEY_TYPE, HashSet<VALUE_TYPE>> item, IEnumerable<KEY_TYPE> keys)
        {
            return keys.Convert(k => item.GetValues(k)).Flatten();
        }

        static public IEnumerable<VALUE_TYPE> GetAll<KEY_TYPE, VALUE_TYPE>(this IDictionary<KEY_TYPE, HashSet<VALUE_TYPE>> item)
        {
            return item.Values.Flatten();
        }

        static public void CullEmpty<KEY_TYPE, VALUE_TYPE>(this IDictionary<KEY_TYPE, HashSet<VALUE_TYPE>> item)
        {
            item.RemoveAll(p => p.Value.IsEmpty());
        }
    }
}