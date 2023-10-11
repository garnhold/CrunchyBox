using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    static public class SiTTokens
    {
        static public TokenDefinition Normal(string n, string sit)
        {
            return TokenDefinitions.Normal(n, TokenPatterns.SiT(sit));
        }
        static public TokenDefinition Normal(string sit)
        {
            return Normal(null, sit);
        }

        static public TokenDefinition Ignore(string n, string sit)
        {
            return TokenDefinitions.Ignore(n, TokenPatterns.SiT(sit));
        }
        static public TokenDefinition Ignore(string sit)
        {
            return Ignore(null, sit);
        }

        static public TokenDefinition ModePusher(string n, string sit, TokenModeInstance m)
        {
            return TokenDefinitions.ModePusher(n, TokenPatterns.SiT(sit), m);
        }
        static public TokenDefinition ModePusher(string sit, TokenModeInstance m)
        {
            return ModePusher(null, sit, m);
        }

        static public TokenDefinition ModePusher(string n, string sit, TokenMode m, IEnumerable<TokenDefinition> a)
        {
            return ModePusher(n, sit, m.Instance(a));
        }
        static public TokenDefinition ModePusher(string sit, TokenMode m, IEnumerable<TokenDefinition> a)
        {
            return ModePusher(null, sit, m, a);
        }

        static public TokenDefinition ModePusher(string n, string sit, TokenMode m, params TokenDefinition[] a)
        {
            return ModePusher(n, sit, m, (IEnumerable<TokenDefinition>)a);
        }
        static public TokenDefinition ModePusher(string sit, TokenMode m, params TokenDefinition[] a)
        {
            return ModePusher(null, sit, m, a);
        }

        static public TokenDefinition ModePopper(string n, string sit)
        {
            return TokenDefinitions.ModePopper(n, TokenPatterns.SiT(sit));
        }
        static public TokenDefinition ModePopper(string sit)
        {
            return ModePopper(null, sit);
        }

        static public TokenDefinition JunkString(string n)
        {
            return TokenDefinitions.Normal(n, TokenPatterns.JunkString());
        }
        static public TokenDefinition JunkString()
        {
            return JunkString(null);
        }

        static public TokenDefinition JunkCharacter(string n)
        {
            return TokenDefinitions.Normal(n, TokenPatterns.JunkCharacter());
        }
        static public TokenDefinition JunkCharacter()
        {
            return JunkCharacter(null);
        }
    }
}