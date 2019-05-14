using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchyStrudel
{
    public class AIRuleSystem<T>
    {
        private T entity;
        private List<AIRule<T>> rules;

        public AIRuleSystem(T e)
        {
            entity = e;
            rules = new List<AIRule<T>>();
        }

        public AIRuleSystem(T e, IEnumerable<AIRule<T>> r) : this(e)
        {
            this.Add(r);
        }
        public AIRuleSystem(T e, params AIRule<T>[] r) : this(e, (IEnumerable<AIRule<T>>)r) { }

        public void Observe(int channel_mask)
        {
            rules.Apply(channel_mask, (m, r) => r.Observe(m));
        }
        public void Observe()
        {
            Observe(IntBits.ALL_BITS);
        }

        public void Upkeep()
        {
            rules.Process(r => r.Upkeep());
        }

        public void Add(AIRule<T> rule)
        {
            if (rule != null)
            {
                rules.Add(rule);
                rule.SetRuleSystem(this);
            }
        }

        public T GetEntity()
        {
            return entity;
        }
    }
}