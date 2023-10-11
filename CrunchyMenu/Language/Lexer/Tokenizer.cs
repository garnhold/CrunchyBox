using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class Tokenizer
    {
        private Stack<TokenModeInstance> token_mode_instance_stack;

        public Tokenizer(TokenModeInstance initial_token_mode)
        {
            token_mode_instance_stack = new Stack<TokenModeInstance>();

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

        public void PushTokenMode(TokenModeInstance token_mode)
        {
            token_mode_instance_stack.Push(token_mode);
        }
        public void PopTokenMode()
        {
            token_mode_instance_stack.Pop();
        }

        public TokenModeInstance GetCurrentTokenMode()
        {
            return token_mode_instance_stack.Peek();
        }

        public JunkTokenBehaviour GetCurrentJunkTokenBehaviour()
        {
            return GetCurrentTokenMode().GetJunkTokenBehaviour();
        }

        public TokenDefinition GetCurrentJunkTokenDefinition()
        {
            return GetCurrentTokenMode().GetJunkTokenDefinition();
        }
    }
}