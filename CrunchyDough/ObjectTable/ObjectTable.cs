using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ObjectTable<OBJECT_TYPE, VALUE_TYPE> : LookupSet<OBJECT_TYPE, VALUE_TYPE> where OBJECT_TYPE : class
    {
        private GCNotifier notifier;

        private object dictionary_lock;
        private Dictionary<object, VALUE_TYPE> dictionary;

        public ObjectTable()
        {
            notifier = new GCNotifier_Process(Cull);

            dictionary_lock = new object();
            dictionary = new Dictionary<object, VALUE_TYPE>(WeakKeyComparer<OBJECT_TYPE>.INSTANCE);
        }

        public void Clear()
        {
            lock (dictionary_lock)
            {
                dictionary.Clear();
            }
        }

        public void Set(OBJECT_TYPE key, VALUE_TYPE value)
        {
            lock (dictionary_lock)
            {
                dictionary[new WeakKey<OBJECT_TYPE>(key)] = value;
            }
        }

        public void Add(OBJECT_TYPE key, VALUE_TYPE value)
        {
            lock (dictionary_lock)
            {
                dictionary.Add(new WeakKey<OBJECT_TYPE>(key), value);
            }
        }

        public bool Remove(OBJECT_TYPE key)
        {
            lock (dictionary_lock)
            {
                return dictionary.Remove(key);
            }
        }

        public void Process(Process<KeyValuePair<object, VALUE_TYPE>> process)
        {
            lock (dictionary_lock)
            {
                dictionary.Reduce(delegate(KeyValuePair<object, VALUE_TYPE> pair) {
                    if (WeakKey<OBJECT_TYPE>.DereferenceIsNull(pair.Key) == false)
                    {
                        process(pair);

                        return true;
                    }

                    return false;
                });
            }
        }

        public void Cull()
        {
            Process(p => { });
        }

        public bool Has(OBJECT_TYPE key)
        {
            lock (dictionary_lock)
            {
                if (dictionary.ContainsKey(key))
                    return true;

                return false;
            }
        }

        public bool TryLookup(OBJECT_TYPE key, out VALUE_TYPE value)
        {
            lock (dictionary_lock)
            {
                return dictionary.TryGetValue(key, out value);
            }
        }
    }
}