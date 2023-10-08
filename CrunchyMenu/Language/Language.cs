using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class Language
    {
        private Lexer lexer;
        private Parser parser;

        public Language()
        {
        }

        public Lexer GetLexer()
        {
            return lexer;
        }

        public Parser GetParser()
        {
            return parser;
        }
    }
}