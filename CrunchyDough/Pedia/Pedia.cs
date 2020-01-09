using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class Pedia<KEY_TYPE, VALUE_TYPE> : IEnumerable<KeyValuePair<KEY_TYPE, VALUE_TYPE>>
    {
        private Operation<VALUE_TYPE, KEY_TYPE> initial_value_operation;
        private IDictionary<KEY_TYPE, VALUE_TYPE> dictionary;

        public VALUE_TYPE this[KEY_TYPE key]
        {
            set { SetValue(key, value); }
            get { return GetValue(key); }
        }

        protected Pedia(Operation<VALUE_TYPE, KEY_TYPE> o, IDictionary<KEY_TYPE, VALUE_TYPE> d)
        {
            initial_value_operation = o;
            dictionary = d;
        }

        public Pedia(Operation<VALUE_TYPE, KEY_TYPE> o) : this(o, new Dictionary<KEY_TYPE, VALUE_TYPE>()) { }
        public Pedia(Operation<VALUE_TYPE> o) : this(k => o(), new Dictionary<KEY_TYPE, VALUE_TYPE>()) { }

        public Pedia(VALUE_TYPE i) : this(k => i, new Dictionary<KEY_TYPE, VALUE_TYPE>()) { }

        public void Clear()
        {
            dictionary.Clear();
        }

        public void SetValue(KEY_TYPE key, VALUE_TYPE value)
        {
            dictionary[key] = value;
        }

        public void Remove(KEY_TYPE key)
        {
            dictionary.Remove(key);
        }

        public VALUE_TYPE GetValue(KEY_TYPE key)
        {
            return dictionary.GetOrCreateValue(key, initial_value_operation);
        }

        public IEnumerator<KeyValuePair<KEY_TYPE, VALUE_TYPE>> GetEnumerator()
        {
            return dictionary.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}