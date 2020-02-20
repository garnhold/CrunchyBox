using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class DecayCountDictionary<KEY_TYPE, VALUE_TYPE> : IEnumerable<KeyValuePair<KEY_TYPE, VALUE_TYPE>>
    {
        private Dictionary<KEY_TYPE, DecayCountElement<VALUE_TYPE>> dictionary;

        public DecayCountDictionary()
        {
            dictionary = new Dictionary<KEY_TYPE, DecayCountElement<VALUE_TYPE>>();
        }

        public void Decay()
        {
            dictionary.RemoveAll(p => p.Value.Decay());
        }

        public bool Add(KEY_TYPE key, VALUE_TYPE value, int lifetime, bool recharge)
        {
            DecayCountElement<VALUE_TYPE> element;

            if (dictionary.TryGetValue(key, out element))
            {
                element.SetData(value);

                if (recharge)
                    element.Reset(lifetime);

                return false;
            }

            dictionary[key] = new DecayCountElement<VALUE_TYPE>(value, lifetime);
            return true;
        }

        public bool Has(KEY_TYPE to_check)
        {
            if (dictionary.ContainsKey(to_check))
                return true;

            return false;
        }

        public IEnumerator<KeyValuePair<KEY_TYPE, VALUE_TYPE>> GetEnumerator()
        {
            return dictionary
                .Convert(p => new KeyValuePair<KEY_TYPE, VALUE_TYPE>(p.Key, p.Value.GetData()))
                .GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}