using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class FragmentDefinition_Never<T> : FragmentDefinition<T>
    {
        public static readonly FragmentDefinition_Never<T> INSTANCE = new FragmentDefinition_Never<T>();

        protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
        {
            new_index = -1;
            producer = null;
            return false;
        }

        private FragmentDefinition_Never()
        {
        }

        public override bool IsRequired()
        {
            return true;
        }
    }
}