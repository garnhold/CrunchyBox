using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class FragmentDefinition_Skip<T> : FragmentDefinition<T>
    {
        private Operation<T> operation;

        public static readonly FragmentDefinition_Skip<T> INSTANCE = new FragmentDefinition_Skip<T>();

        protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
        {
            new_index = index;
            producer = operation;
            return true;
        }

        private FragmentDefinition_Skip()
        {
            operation = () => default(T);
        }

        public override bool CanConsumeNone()
        {
            return true;
        }
    }
}