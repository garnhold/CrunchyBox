using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class AutoToken
    {
        private Dictionary<string, TokenDefinition> tokens;

        private TokenMode token_mode;

        public AutoToken(TokenMode t)
        {
            tokens = new Dictionary<string, TokenDefinition>();

            token_mode = t;
        }

        public TokenDefinition Get(string text)
        {
            return tokens.GetOrCreateValue(text, t => {
                TokenDefinition token_definition = TokenDefinitions.Normal(t);

                token_mode.AddTokenDefinition(token_definition);
                return token_definition;
            });
        }

        public Operation<TokenDefinition, string> GetTOK()
        {
            return Get;
        }
    }
}