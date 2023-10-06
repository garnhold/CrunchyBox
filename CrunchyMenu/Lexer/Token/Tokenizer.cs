using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class Tokenizer
    {
        private Stack<TokenMode> token_mode_stack;

        public Tokenizer(TokenMode initial_token_mode)
        {
            token_mode_stack = new Stack<TokenMode>();

            PushTokenMode(initial_token_mode);
        }

        public bool StepTokenizeInner(string text, ref int index, out TokenInstance token)
        {
            if (GetCurrentTokenMode().Detect(text, index, out int end_index, out TokenDefinition token_definition))
            {
                if (token_definition.OnConsume(this))
                {
                    token = new TokenInstance(
                        text.SubSection(index, end_index),
                        token_definition
                    );
                }
                else
                {
                    token = null;
                }

                index = end_index;
                return true;
            }

            token = null;
            return false;
        }

        public void PushTokenMode(TokenMode token_mode)
        {
            token_mode_stack.Push(token_mode);
        }
        public void PopTokenMode(TokenMode token_mode)
        {
            token_mode_stack.Pop();
        }

        public TokenMode GetCurrentTokenMode()
        {
            return token_mode_stack.Peek();
        }

        public TokenDefinition GetCurrentJunkTokenDefinition()
        {
            return GetCurrentTokenMode().GetJunkTokenDefinition();
        }
    }
}