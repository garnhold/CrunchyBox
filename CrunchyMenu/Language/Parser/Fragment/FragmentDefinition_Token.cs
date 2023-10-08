using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class FragmentDefinition_Token<T> : FragmentDefinition<T>
    {
        private Operation<T, string> producer_operation;

        private TokenDefinition token_definition;

        protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
        {
            TokenInstance current_token = tokens[index];

            if (current_token.GetTokenDefinition() == token_definition)
            {
                new_index = index + 1;
                producer = () => producer_operation(current_token.GetValue());
                return true;
            }

            new_index = -1;
            producer = null;
            return false;
        }

        public FragmentDefinition_Token(Language l) : base(l)
        {
        }

        public FragmentDefinition_Token(Language l, TokenDefinition t, Operation<T, string> o) : this(l)
        {
            Initialize(t, o);
        }

        public void Initialize(TokenDefinition t, Operation<T, string> o)
        {
            token_definition = t;

            producer_operation = o;
        }

        public override bool CanConsumeNone()
        {
            return false;
        }
    }
    static public partial class LanguageExtensions
    {
        static public FragmentDefinition<T> Token<T>(this Language item, TokenDefinition t, Operation<T, string> o)
        {
            return new FragmentDefinition_Token<T>(item, t, o);
        }
    }
}