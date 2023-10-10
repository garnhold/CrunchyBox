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
            if (index < tokens.Count)
            {
                TokenInstance current_token = tokens[index];

                if (current_token.GetTokenDefinition() == token_definition)
                {
                    new_index = index + 1;
                    producer = () => producer_operation(current_token.GetValue());
                    return true;
                }
            }

            new_index = -1;
            producer = null;
            return false;
        }

        protected override string GetMaybeLabel()
        {
            return token_definition.GetLabel();
        }

        public FragmentDefinition_Token(string n) : base(n)
        {
        }

        public FragmentDefinition_Token(string n, TokenDefinition t, Operation<T, string> o) : this(n)
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

        public override string GetPsuedoRegEx()
        {
            return "<" + token_definition.ToString() + ">";
        }
    }
    static public partial class FragmentDefinitions
    {
        static public FragmentDefinition<T> Token<T>(string n, TokenDefinition t, Operation<T, string> o)
        {
            return new FragmentDefinition_Token<T>(n, t, o);
        }
        static public FragmentDefinition<T> Token<T>(TokenDefinition t, Operation<T, string> o)
        {
            return Token(null, t, o);
        }
    }
}