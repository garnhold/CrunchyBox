using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class EmptyDictionary<KEY_TYPE, VALUE_TYPE> : IDictionary<KEY_TYPE, VALUE_TYPE>
    {
        static public readonly EmptyDictionary<KEY_TYPE, VALUE_TYPE> INSTANCE = new EmptyDictionary<KEY_TYPE,VALUE_TYPE>();

        public ICollection<KEY_TYPE> Keys { get { return Empty.ICollection<KEY_TYPE>(); } }
        public ICollection<VALUE_TYPE> Values { get { return Empty.ICollection<VALUE_TYPE>(); } }

        public int Count { get { return 0; } }
        public bool IsReadOnly { get { return true; } }

        public VALUE_TYPE this[KEY_TYPE key]
        {
            get
            {
                throw new KeyNotFoundException();
            }

            set
            {
                throw new InvalidOperationException("EmptyDictionary is Read Only");
            }
        }

        public void Clear()
        {
            throw new InvalidOperationException("EmptyDictionary is Read Only");
        }

        public void Add(KEY_TYPE key, VALUE_TYPE value)
        {
            throw new InvalidOperationException("EmptyDictionary is Read Only");
        }
        public void Add(KeyValuePair<KEY_TYPE, VALUE_TYPE> item)
        {
            throw new InvalidOperationException("EmptyDictionary is Read Only");
        }

        public bool ContainsKey(KEY_TYPE key)
        {
            return false;
        }

        public bool Contains(KeyValuePair<KEY_TYPE, VALUE_TYPE> item)
        {
            return false;
        }

        public bool Remove(KEY_TYPE key)
        {
            throw new InvalidOperationException("EmptyDictionary is Read Only");
        }
        public bool Remove(KeyValuePair<KEY_TYPE, VALUE_TYPE> item)
        {
            throw new InvalidOperationException("EmptyDictionary is Read Only");
        }

        public void CopyTo(KeyValuePair<KEY_TYPE, VALUE_TYPE>[] array, int arrayIndex)
        {
        }

        public bool TryGetValue(KEY_TYPE key, out VALUE_TYPE value)
        {
            value = default(VALUE_TYPE);
            return false;
        }

        public IEnumerator<KeyValuePair<KEY_TYPE, VALUE_TYPE>> GetEnumerator()
        {
            return EmptyEnumerator<KeyValuePair<KEY_TYPE, VALUE_TYPE>>.INSTANCE;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}