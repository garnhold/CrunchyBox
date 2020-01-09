using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class SyntheticDictionary<KEY_TYPE, VALUE_TYPE> : IDictionary<KEY_TYPE, VALUE_TYPE>
    {
        private Dictionary<KEY_TYPE, VALUE_TYPE> actual_dictionary;

        private bool is_dirty;

        public bool IsReadOnly { get{ return false; } }
        public int Count { get{ return actual_dictionary.Count; } }

        public ICollection<KEY_TYPE> Keys { get{ return actual_dictionary.Keys; } }
        public ICollection<VALUE_TYPE> Values { get{ return actual_dictionary.Values; } }

        protected abstract void CleanInternal();
        protected abstract bool TryGetValueInternal(KEY_TYPE key, out VALUE_TYPE value);

        protected IDictionary<KEY_TYPE, VALUE_TYPE> GetActualDictionary()
        {
            return actual_dictionary;
        }

        public VALUE_TYPE this[KEY_TYPE key]
        {
            get{ return this.GetValue(key); }

            set
            {
                actual_dictionary[key] = value;

                is_dirty = true;
            }
        }

        private void Clean()
        {
            if (is_dirty)
            {
                CleanInternal();

                is_dirty = false;
            }
        }

        public SyntheticDictionary()
        {
            actual_dictionary = new Dictionary<KEY_TYPE, VALUE_TYPE>();

            is_dirty = true;
        }

        public void Clear()
        {
            actual_dictionary.Clear();

            is_dirty = true;
            Clean();
        }

        public void Add(KEY_TYPE key, VALUE_TYPE value)
        {
            actual_dictionary.Add(key, value);

            is_dirty = true;
        }
        public void Add(KeyValuePair<KEY_TYPE, VALUE_TYPE> pair)
        {
            Add(pair.Key, pair.Value);
        }

        public bool Remove(KEY_TYPE key)
        {
            if (actual_dictionary.Remove(key))
            {
                is_dirty = true;
                return true;
            }

            return false;
        }
        public bool Remove(KeyValuePair<KEY_TYPE, VALUE_TYPE> pair)
        {
            return Remove(pair.Key);
        }

        public bool TryGetValue(KEY_TYPE key, out VALUE_TYPE value)
        {
            Clean();

            return TryGetValueInternal(key, out value);
        }

        public void CopyTo(KeyValuePair<KEY_TYPE, VALUE_TYPE>[] array, int index)
        {
            ((IDictionary<KEY_TYPE, VALUE_TYPE>)actual_dictionary).CopyTo(array, index);
        }

        public bool ContainsKey(KEY_TYPE key)
        {
            VALUE_TYPE value;

            if (TryGetValue(key, out value))
                return true;

            return false;
        }
        public bool Contains(KeyValuePair<KEY_TYPE, VALUE_TYPE> pair)
        {
            VALUE_TYPE value;

            if (TryGetValue(pair.Key, out value))
            {
                if (value.EqualsEX(pair.Value))
                    return true;
            }

            return false;
        }

        public IEnumerator<KeyValuePair<KEY_TYPE, VALUE_TYPE>> GetEnumerator()
        {
            return actual_dictionary.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}