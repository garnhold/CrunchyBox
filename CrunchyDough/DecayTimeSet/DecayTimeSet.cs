using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class DecayTimeSet<T> : IEnumerable<T>
    {
        private Dictionary<T, TemporalEvent> elements;

        public DecayTimeSet()
        {
            elements = new Dictionary<T, TemporalEvent>();
        }

        public void Decay()
        {
            elements.RemoveAll(p => p.Value.IsTimeOver());
        }

        public bool Add(T to_add, Operation<TemporalEvent> operation, bool recharge)
        {
            TemporalEvent timer;

            if (elements.TryGetValue(to_add, out timer) && timer.IsTimeUnder())
            {
                if (recharge)
                    timer.Restart();

                return false;
            }

            elements[to_add] = operation().StartAndGet();
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