using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class FragmentDefinition_Any<T> : FragmentDefinition<T>
    {
        private List<FragmentDefinition<T>> fragment_definitions;

        protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
        {
            int best_index = int.MinValue;
            Operation<T> best_producer = null;

            foreach (FragmentDefinition<T> fragment_definition in fragment_definitions)
            {
                if (fragment_definition.Consume(tokens, index, out new_index, out producer))
                {
                    if (new_index >= best_index)
                    {
                        best_index = new_index;
                        best_producer = producer;
                    }
                }
            }

            if (best_producer != null)
            {
                new_index = best_index;
                producer = best_producer;
                return true;
            }

            new_index = -1;
            producer = null;
            return false;
        }

        public FragmentDefinition_Any(Language l) : base(l)
        {
            fragment_definitions = new List<FragmentDefinition<T>>();
        }

        public FragmentDefinition_Any(Language l, IEnumerable<FragmentDefinition<T>> f) : this(l)
        {
            Initialize(f);
        }
        public FragmentDefinition_Any(Language l, params FragmentDefinition<T>[] f) : this(l, (IEnumerable<FragmentDefinition<T>>)f) { }

        public void Initialize(IEnumerable<FragmentDefinition<T>> f)
        {
            fragment_definitions.Set(f);
        }
        public void Initialize(params FragmentDefinition<T>[] f)
        {
            Initialize((IEnumerable<FragmentDefinition<T>>)f);
        }

        public override bool CanConsumeNone()
        {
            if (fragment_definitions.Has(f => f.CanConsumeNone()))
                return true;

            return false;
        }
    }
    static public partial class LanguageExtensions
    {
        static public FragmentDefinition<T> Any<T>(this Language item, IEnumerable<FragmentDefinition<T>> f)
        {
            return new FragmentDefinition_Any<T>(item, f);
        }
        static public FragmentDefinition<T> Any<T>(this Language item, params FragmentDefinition<T>[] f)
        {
            return item.Any((IEnumerable<FragmentDefinition<T>>)f);
        }
    }
}