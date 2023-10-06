using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class Lexer
    {
        private TokenMode default_token_mode;

        public Lexer(TokenMode d)
        {
            default_token_mode = d;
        }

        public IEnumerable<TokenInstance> Tokenize(string text)
        {
            return new Tokenizer(default_token_mode).Tokenize(text);
        }
    }
}