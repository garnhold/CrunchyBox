using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class FragmentDefinition_Convert<T, J> : FragmentDefinition<T>
    {
        private FragmentDefinition<J> fragment_definition;
        private Operation<T, J> operation;

        protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
        {
            if (fragment_definition.Consume(tokens, index, out new_index, out Operation<J> sub_producer))
            {
                producer = () => operation(sub_producer());
                return true;
            }

            producer = null;
            return false;
        }

        protected override string GetMaybeLabel()
        {
            return fragment_definition.GetLabel();
        }

        public FragmentDefinition_Convert(string n) : base(n)
        {
        }

        public FragmentDefinition_Convert(string n, FragmentDefinition<J> f, Operation<T, J> o) : this(n)
        {
            Initialize(f, o);
        }

        public void Initialize(FragmentDefinition<J> f, Operation<T, J> o)
        {
            fragment_definition = f;
            operation = o;
        }

        public override bool CanConsumeNone()
        {
            return fragment_definition.CanConsumeNone();
        }

        public override string GetPsuedoRegEx()
        {
            return fragment_definition.GetPsuedoRegEx();
        }
    }
    static public partial class FragmentDefinitions
    {
        static public FragmentDefinition<T> Convert<T, J>(string n, FragmentDefinition<J> f, Operation<T, J> o)
        {
            return new FragmentDefinition_Convert<T, J>(n, f, o);
        }
        static public FragmentDefinition<T> Convert<T, J>(FragmentDefinition<J> f, Operation<T, J> o)
        {
            return Convert(null, f, o);
        }
    }
}