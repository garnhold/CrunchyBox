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
        public bool IsReadOnly { get { return false; } }

        public VALUE_TYPE this[KEY_TYPE key]
        {
            get { return dictionary[key].GetData(); }
            set
            {
                StaleDictionaryElement<VALUE_TYPE> element;

                if (dictionary.TryGetValue(key, out element))
                    element.SetData(value, stale_id);
                else
                    Add(key, value);
            }
        }

        public ICollection<KEY_TYPE> Keys { get { return dictionary.Keys; } }
        public ICollection<VALUE_TYPE> Values { get { return dictionary.Values.Convert(v => v.GetData()); } }

        public void MarkStale()
        {
            stale_id++;
        }

        public void RemoveStale(Process<KeyValuePair<KEY_TYPE, VALUE_TYPE>> process)
        {
            dictionary.RemoveAll(delegate(KeyValuePair<KEY_TYPE, StaleDictionaryElement<VALUE_TYPE>> pair) {
                if (pair.Value.IsStale(stale_id))
                {
                    process(new KeyValuePair<KEY_TYPE, VALUE_TYPE>(pair.Key, pair.Value.GetData()));

                    return true;
                }

                return false;
            });
        }

        public void Clear()
        {
            dictionary.Clear();
        }

        public void Add(KEY_TYPE key, VALUE_TYPE value)
        {
            dictionary.Add(key, new StaleDictionaryElement<VALUE_TYPE>(value, stale_id));
        }

        public void Add(KeyValuePair<KEY_TYPE, VALUE_TYPE> item)
        {
            Add(item.Key, item.Value);
        }

        public bool ContainsKey(KEY_TYPE key)
        {
            return dictionary.ContainsKey(key);
        }

        public bool Contains(KeyValuePair<KEY_TYPE, VALUE_TYPE> item)
        {
            VALUE_TYPE value;

            if (TryGetValue(item.Key, out value))
            {
                if (value.EqualsEX(item.Value))
                    return true;
            }

            return false;
        }

        public bool Remove(KEY_TYPE key)
        {
            return dictionary.Remove(key);
        }

        public bool Remove(KeyValuePair<KEY_TYPE, VALUE_TYPE> item)
        {
            return Remove(item.Key);
        }

        public void CopyTo(KeyValuePair<KEY_TYPE, VALUE_TYPE>[] array, int arrayIndex)
        {
            foreach (KeyValuePair<KEY_TYPE, VALUE_TYPE> pair in this)
                array[arrayIndex++] = pair;
        }

        public bool TryGetValue(KEY_TYPE key, out VALUE_TYPE value)
        {
            StaleDictionaryElement<VALUE_TYPE> element;

            if (dictionary.TryGetValue(key, out element))
            {
                value = element.GetData();
                return true;
            }

            value = default(VALUE_TYPE);
            return false;
        }

        public IEnumerator<KeyValuePair<KEY_TYPE, VALUE_TYPE>> GetEnumerator()
        {
            return dictionary.Convert(p => new KeyValuePair<KEY_TYPE, VALUE_TYPE>(p.Key, p.Value.GetData()))
                .GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}