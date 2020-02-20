using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class StaleDictionary<KEY_TYPE, VALUE_TYPE> : IDictionary<KEY_TYPE, VALUE_TYPE>
    {
        private Dictionary<KEY_TYPE, StaleDictionaryElement<VALUE_TYPE>> dictionary;
        private int stale_id;

        public int Count { get { return dictionary.Count; } }

        public VALUE_TYPE this[KEY_TYPE key]
        {
            get { return dictionary[key].GetData(); }
            set { dictionary[key].SetData(value, stale_id); }
        }
        TValue this[TKey key]
        {
            get;
            set;
        }

        ICollection<TKey> Keys
        {
            get;
        }

        ICollection<TValue> Values
        {
            get;
        }

        void Add(TKey key, TValue value);

        bool ContainsKey(TKey key);

        bool Remove(TKey key);

        bool TryGetValue(TKey key, out TValue value);

        int Count
        {
            get;
        }

        bool IsReadOnly
        {
            get;
        }

        void Add(T item);

        void Clear();

        bool Contains(T item);

        void CopyTo(T[] array, int arrayIndex);

        bool Remove(T item);
    }
}