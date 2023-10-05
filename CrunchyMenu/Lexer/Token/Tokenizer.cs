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

        public bool Detect(string text, int index, out int new_index, out TokenDefinition token_definition)
        {
            return token_mode_stack
                .Peek()
                .Detect(text, index, out new_index, out token_definition);
        }

        public void PushTokenMode(TokenMode token_mode)
        {
            token_mode_stack.Push(token_mode);
        }
        public void PopTokenMode(TokenMode token_mode)
        {
            token_mode_stack.Pop();
        }
    }
}