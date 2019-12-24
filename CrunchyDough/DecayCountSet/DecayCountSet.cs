using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class DecayCountSet<T> : IEnumerable<T>
    {
        private Dictionary<T, DecayCounter> elements;

        public DecayCountSet()
        {
            elements = new Dictionary<T, DecayCounter>();
        }

        public void Decay()
        {
            elements.RemoveAll(p => p.Value.Decay());
        }

        public bool Add(T to_add, int lifetime, bool recharge)
        {
            DecayCounter decay_counter;

            if (elements.TryGetValue(to_add, out decay_counter))
            {
                if (recharge)
                    decay_counter.Reset(lifetime);

                return false;
            }

            elements[to_add] = new DecayCounter(lifetime);
            return true;
        }

        public bool Has(T to_check)
        {
            if (elements.ContainsKey(to_check))
                return true;

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return elements.Keys.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}