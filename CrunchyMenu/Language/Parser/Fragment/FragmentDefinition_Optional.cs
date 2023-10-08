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

        public FragmentDefinition_Optional(Language l) : base(l)
        {
        }

        public FragmentDefinition_Optional(Language l, FragmentDefinition<T> f) : this(l)
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
    }
    static public partial class LanguageExtensions
    {
        static public FragmentDefinition<T> Optional<T>(this Language item, FragmentDefinition<T> f)
        {
            return new FragmentDefinition_Optional<T>(item, f);
        }
    }
}