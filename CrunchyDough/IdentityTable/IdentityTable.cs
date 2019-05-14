using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class IdentityTable<ID_TYPE, OBJECT_TYPE> : LookupSet<ID_TYPE, OBJECT_TYPE> where OBJECT_TYPE : class
    {
        private GCNotifier notifier;

        private object dictionary_lock;
        private Dictionary<ID_TYPE, WeakReference<OBJECT_TYPE>> dictionary;

        public IdentityTable()
        {
            notifier = new GCNotifier_Process(Cull);

            dictionary_lock = new object();
            dictionary = new Dictionary<ID_TYPE, WeakReference<OBJECT_TYPE>>();
        }

        public void Clear()
        {
            lock (dictionary_lock)
            {
                dictionary.Clear();
            }
        }

        public void Set(ID_TYPE key, OBJECT_TYPE value)
        {
            lock (dictionary_lock)
            {
                dictionary[key] = new WeakReference<OBJECT_TYPE>(value);
            }
        }

        public void Add(ID_TYPE key, OBJECT_TYPE value)
        {
            lock (dictionary_lock)
            {
                dictionary.Add(key, new WeakReference<OBJECT_TYPE>(value));
            }
        }

        public bool Remove(ID_TYPE key)
        {
            lock (dictionary_lock)
            {
                return dictionary.Remove(key);
            }
        }

        public void Process(Process<KeyValuePair<ID_TYPE, OBJECT_TYPE>> process)
        {
            lock (dictionary_lock)
            {
                dictionary.Reduce(delegate(KeyValuePair<ID_TYPE, WeakReference<OBJECT_TYPE>> pair) {
                    if (pair.Value.IsAlive())
                    {
                        process(KeyValuePair.New(pair.Key, pair.Value.Get()));

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

        public bool Has(ID_TYPE key)
        {
            lock (dictionary_lock)
            {
                OBJECT_TYPE value;

                if (TryLookup(key, out value))
                    return true;

                return false;
            }
        }

        public bool TryLookup(ID_TYPE key, out OBJECT_TYPE value)
        {
            lock (dictionary_lock)
            {
                WeakReference<OBJECT_TYPE> temp;

                if (dictionary.TryGetValue(key, out temp))
                {
                    if (temp.IsAlive())
                    {
                        value = temp.Get();
                        return true;
                    }

                    dictionary.Remove(key);
                }

                value = default(OBJECT_TYPE);
                return false;
            }
        }
    }
}