using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class Table<KEY_TYPE, VALUE_TYPE> : LookupSet<KEY_TYPE, VALUE_TYPE>, IEnumerable<KeyValuePair<KEY_TYPE, VALUE_TYPE>>
    {
        private Dictionary<KEY_TYPE, VALUE_TYPE> table;

        protected abstract KEY_TYPE PrepareKey(KEY_TYPE key);
        protected abstract VALUE_TYPE PrepareValue(VALUE_TYPE value);

        public Table()
        {
            table = new Dictionary<KEY_TYPE, VALUE_TYPE>();
        }
        public Table(IEnumerable<KeyValuePair<KEY_TYPE, VALUE_TYPE>> pairs) : this()
        {
            Add(pairs);
        }
        public Table(params KeyValuePair<KEY_TYPE, VALUE_TYPE>[] pairs) : this()
        {
            Add(pairs);
        }

        public void Clear()
        {
            table.Clear();
        }

        public void Set(KEY_TYPE key, VALUE_TYPE value)
        {
            table[PrepareKey(key)] = PrepareValue(value);
        }
        public void Set(KeyValuePair<KEY_TYPE, VALUE_TYPE> pair)
        {
            Set(pair.Key, pair.Value);
        }

        public void Add(IEnumerable<KeyValuePair<KEY_TYPE, VALUE_TYPE>> pairs)
        {
            foreach (KeyValuePair<KEY_TYPE, VALUE_TYPE> pair in pairs)
                Set(pair);
        }
        public void Add(params KeyValuePair<KEY_TYPE, VALUE_TYPE>[] pairs)
        {
            Add((IEnumerable<KeyValuePair<KEY_TYPE, VALUE_TYPE>>)pairs);
        }
        public void Add(Table<KEY_TYPE, VALUE_TYPE> pairs)
        {
            Add(pairs.table);
        }

        public bool Remove(KEY_TYPE key)
        {
            return table.Remove(key);
        }

        public bool Has(KEY_TYPE key)
        {
            return table.ContainsKey(PrepareKey(key));
        }

        public bool TryLookup(KEY_TYPE key, out VALUE_TYPE value)
        {
            return table.TryGetValue(PrepareKey(key), out value);
        }

        public IEnumerator<KeyValuePair<KEY_TYPE, VALUE_TYPE>> GetEnumerator()
        {
            return table.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}