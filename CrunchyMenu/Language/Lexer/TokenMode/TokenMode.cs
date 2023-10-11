using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenMode
    {
        private int state;

        private TokenDefinition junk_token_definition;
        private JunkTokenBehaviour junk_token_behaviour;

        private List<TokenDefinition> token_definitions;
        private Dictionary<string, TokenDefinition> auto_token_definitions;

        static public implicit operator TokenModeInstance(TokenMode t)
        {
            return t.Instance();
        }

        public TokenMode()
        {
            state = 1;

            token_definitions = new List<TokenDefinition>();
            auto_token_definitions = new Dictionary<string, TokenDefinition>();
        }

        public TokenModeInstance Instance(IEnumerable<TokenDefinition> additional_token_definitions)
        {
            return new TokenModeInstance(this, additional_token_definitions);
        }
        public TokenModeInstance Instance(params TokenDefinition[] additional_token_definitions)
        {
            return Instance((IEnumerable<TokenDefinition>)additional_token_definitions);
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
            }

            state++;
        }

        public void AddTokenDefinitions(IEnumerable<TokenDefinition> token_definitions)
        {
            token_definitions.Process(d => AddTokenDefinition(d));
        }
        public void AddTokenDefinitions(params TokenDefinition[] token_definitions)
        {
            AddTokenDefinitions((IEnumerable<TokenDefinition>)token_definitions);
        }

        public TokenDefinition GetAutoTokenDefinition(string text)
        {
            return auto_token_definitions.GetOrCreateValue(text, t => {
                state++;

                return TokenDefinitions.Normal(t);
            });
        }

        public bool NeedUpdate(ref int old_state)
        {
            if (old_state != state)
            {
                old_state = state;
                return true;
            }

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

        public IEnumerable<TokenDefinition> GetTokenDefinitions()
        {
            return token_definitions.Append(auto_token_definitions.Values);
        }
    }
}