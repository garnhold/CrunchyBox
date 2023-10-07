using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class FragmentDefinitionVoid_Token : FragmentDefinitionVoid
    {
        private TokenDefinition token_definition;

        protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index)
        {
            TokenInstance current_token = tokens[index];

            if (current_token.GetTokenDefinition() == token_definition)
            {
                new_index = index + 1;
                return true;
            }

            new_index = -1;
            return false;
        }

        public FragmentDefinitionVoid_Token()
        {
        }

        public FragmentDefinitionVoid_Token(TokenDefinition t) : this()
        {
            Initialize(t);
        }

        public void Initialize(TokenDefinition t)
        {
            token_definition = t;
        }
    }

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

        public FragmentDefinition_Token()
        {
        }

        public FragmentDefinition_Token(TokenDefinition t, Operation<T, string> o) : this()
        {
            Initialize(t, o);
        }

        public void Initialize(TokenDefinition t, Operation<T, string> o)
        {
            token_definition = t;

            producer_operation = o;
        }
    }
}