using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class FragmentDefinition_Repeated<T> : FragmentDefinition<T[]>
    {
        private FragmentDefinition<T> fragment_definition;

        private int minimum_count;
        private int maximum_count;

        protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T[]> producer)
        {
            new_index = index;
            producer = null;

            List<Operation<T>> sub_producers = new List<Operation<T>>();

            while (fragment_definition.Consume(tokens, new_index, out new_index, out Operation<T> sub_producer))
            {
                sub_producers.Add(sub_producer);

                if (sub_producers.Count > maximum_count)
                    return false;
            }

            if (sub_producers.Count < minimum_count || sub_producers.Count < 1)
                return false;

            producer = () => sub_producers.Convert(p => p()).ToArray();
            return true;
        }

        public FragmentDefinition_Repeated()
        {
        }

        public FragmentDefinition_Repeated(FragmentDefinition<T> f, int min, int max) : this()
        {
            Initialize(f, min, max);
        }

        public void Initialize(FragmentDefinition<T> f, int min, int max)
        {
            fragment_definition = f;

            minimum_count = min;
            maximum_count = max;
        }

        public override bool IsRequired()
        {
            if (minimum_count <= 0)
                return false;

            return true;
        }
    }
}