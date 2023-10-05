using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenInstance
    {
        private string value;

        private TokenDefinition token_definition;

        public TokenInstance(string v, TokenDefinition d)
        {
            value = v;

            token_definition = d;
        }

        public string GetValue()
        {
            return value;
        }

        public TokenDefinition GetTokenDefinition()
        {
            return token_definition;
        }
    }
}