using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class EquivolenceDictionary<KEY_TYPE, VALUE_TYPE> : SyntheticDictionary<KEY_TYPE, VALUE_TYPE>
    {
        private Operation<KeyValuePair<KEY_TYPE, VALUE_TYPE>, KEY_TYPE, IDictionary<KEY_TYPE, VALUE_TYPE>> operation;

        private HashSet<KEY_TYPE> attempted_keys;
        private Dictionary<KEY_TYPE, VALUE_TYPE> cached_dictionary;

        protected override void CleanInternal()
        {
            attempted_keys.Clear();
            cached_dictionary = GetActualDictionary().ToDictionary();
        }

        protected override bool TryGetValueInternal(KEY_TYPE key, out VALUE_TYPE value)
        {
            if (cached_dictionary.TryGetValue(key, out value))
                return true;

            if (attempted_keys.Add(key))
            {
                KeyValuePair<KEY_TYPE, VALUE_TYPE> pair = operation(key, GetActualDictionary());

                if (pair.Key != null)
                {
                    value = pair.Value;

                    cached_dictionary.Add(key, value);
                    return true;
                }
            }

            return false;
        }

        public EquivolenceDictionary(Operation<KeyValuePair<KEY_TYPE, VALUE_TYPE>, KEY_TYPE, IDictionary<KEY_TYPE, VALUE_TYPE>> o)
        {
            operation = o;

            attempted_keys = new HashSet<KEY_TYPE>();
            cached_dictionary = new Dictionary<KEY_TYPE, VALUE_TYPE>();
        }

        public EquivolenceDictionary(Operation<KeyValuePair<KEY_TYPE, VALUE_TYPE>, KEY_TYPE, IDictionary<KEY_TYPE, VALUE_TYPE>> o, IEnumerable<KeyValuePair<KEY_TYPE, VALUE_TYPE>> v) : this(o)
        {
            this.AddRange(v);
        }

        public EquivolenceDictionary(Operation<KeyValuePair<KEY_TYPE, VALUE_TYPE>, KEY_TYPE, IDictionary<KEY_TYPE, VALUE_TYPE>> o, params KeyValuePair<KEY_TYPE, VALUE_TYPE>[] v) : this(o, (IEnumerable<KeyValuePair<KEY_TYPE, VALUE_TYPE>>)v) { }
    }
}