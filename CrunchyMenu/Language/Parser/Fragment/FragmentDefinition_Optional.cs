using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class FragmentDefinition_Optional<T> : FragmentDefinition<T>
    {
        private FragmentDefinition<T> fragment_definition;

        protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
        {
            return fragment_definition.Consume(tokens, index, out new_index, out producer);
        }

        protected override string GetMaybeLabel()
        {
            return fragment_definition.GetLabel() + "?";
        }

        public FragmentDefinition_Optional(string n) : base(n)
        {
        }

        public FragmentDefinition_Optional(string n, FragmentDefinition<T> f) : this(n)
        {
            Initialize(f);
        }

        public void Initialize(FragmentDefinition<T> f)
        {
            fragment_definition = f;
        }

        public override bool CanConsumeNone()
        {
            return true;
        }

        public override string GetPsuedoRegEx()
        {
            return fragment_definition.GetPsuedoRegEx() + "?";
        }
    }
    static public partial class FragmentDefinitions
    {
        static public FragmentDefinition<T> Optional<T>(string n, FragmentDefinition<T> f)
        {
            return new FragmentDefinition_Optional<T>(n, f);
        }
        static public FragmentDefinition<T> Optional<T>(FragmentDefinition<T> f)
        {
            return Optional(null, f);
        }
    }
}