using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenModeInstance
    {
        private TokenMode token_mode;
        private int token_mode_state;

        private List<TokenDefinition> additional_token_definitions;

        private HashSet<TokenDefinition>[] token_definition_map;

        public TokenModeInstance(TokenMode m, IEnumerable<TokenDefinition> a)
        {
            token_mode = m;
            token_mode_state = -1;

            additional_token_definitions = a.ToList();

            token_definition_map = new HashSet<TokenDefinition>[char.MaxValue];
        }

        public TokenModeInstance(TokenMode s, params TokenDefinition[] a) : this(s, (IEnumerable<TokenDefinition>)a) { }

        public void Build()
        {
            if (token_mode.NeedUpdate(ref token_mode_state))
            {
                for (int i = 0; i < token_definition_map.Length; i++)
                    token_definition_map[i] = new HashSet<TokenDefinition>();

                foreach (TokenDefinition token_definition in token_mode.GetTokenDefinitions().Append(additional_token_definitions))
                {
                    token_definition
                        .GetEntrys()
                        .Process(c => token_definition_map[c].Add(token_definition));
                }
            }
        }

        public bool Detect(string text, int index, out int new_index, out TokenDefinition token_definition)
        {
            Build();

            TokenDefinition best_definition = token_definition_map[text[index]]
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

        public JunkTokenBehaviour GetJunkTokenBehaviour()
        {
            return token_mode.GetJunkTokenBehaviour();
        }

        public TokenDefinition GetJunkTokenDefinition()
        {
            return token_mode.GetJunkTokenDefinition();
        }
    }
}