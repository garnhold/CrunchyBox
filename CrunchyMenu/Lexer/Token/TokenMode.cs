using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public abstract class TokenMode
    {
        private List<TokenDefinition> token_definitions;

        public TokenMode()
        {
            token_definitions = new List<TokenDefinition>();
        }

        public bool Detect(string text, int index, out int new_index, out TokenDefinition token_definition)
        {
            TokenDefinition best_definition = token_definitions
                .FindHighestRated(d => d.Detect(text, index), out int best_index);

            if (best_index > index)
            {
                new_index = best_index;
                token_definition = best_definition;
                return true;
            }

            new_index = index;
            token_definition = null;
            return false;
        }
    }
}