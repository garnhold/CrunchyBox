using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenMode
    {
        private bool is_map_built;
        private HashSet<TokenDefinition>[] token_definition_map;

        private TokenDefinition junk_token_definition;
        private JunkTokenBehaviour junk_token_behaviour;

        private List<TokenDefinition> token_definitions;

        public TokenMode()
        {
            is_map_built = false;
            token_definition_map = new HashSet<TokenDefinition>[char.MaxValue];

            token_definitions = new List<TokenDefinition>();
        }

        public void AddTokenDefinition(TokenDefinition token_definition)
        {
            TokenPattern pattern = token_definition.GetTokenPattern();

            if (pattern.Convert<TokenPattern_Junk>(out TokenPattern_Junk junk))
            {
                junk_token_behaviour = junk.GetBehaviour();
                junk_token_definition = token_definition;
            }
            else
            {
                token_definitions.Add(token_definition);
                is_map_built = false;
            }
        }

        public void AddTokenDefinitions(IEnumerable<TokenDefinition> token_definitions)
        {
            token_definitions.Process(d => AddTokenDefinition(d));
        }
        public void AddTokenDefinitions(params TokenDefinition[] token_definitions)
        {
            AddTokenDefinitions((IEnumerable<TokenDefinition>)token_definitions);
        }

        public void Build()
        {
            if (is_map_built == false)
            {
                is_map_built = true;

                for (int i = 0; i < token_definition_map.Length; i++)
                    token_definition_map[i] = new HashSet<TokenDefinition>();

                foreach (TokenDefinition token_definition in token_definitions)
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
            return junk_token_behaviour;
        }

        public TokenDefinition GetJunkTokenDefinition()
        {
            return junk_token_definition;
        }
    }
}