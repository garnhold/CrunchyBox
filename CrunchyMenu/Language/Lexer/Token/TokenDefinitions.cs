using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    static public class TokenDefinitions
    {
        static public TokenDefinition Normal(string n, TokenPattern t)
        {
            return new TokenDefinition(n, t, TokenConsumers.Normal());
        }
        static public TokenDefinition Normal(TokenPattern t)
        {
            return Normal(null, t);
        }

        static public TokenDefinition Ignore(string n, TokenPattern t)
        {
            return new TokenDefinition(n, t, TokenConsumers.Ignore());
        }
        static public TokenDefinition Ignore(TokenPattern t)
        {
            return Ignore(null, t);
        }

        static public TokenDefinition ModePusher(string n, TokenPattern t, TokenMode m)
        {
            return new TokenDefinition(n, t, TokenConsumers.ModePusher(m));
        }
        static public TokenDefinition ModePusher(TokenPattern t, TokenMode m)
        {
            return ModePusher(null, t, m);
        }

        static public TokenDefinition ModePopper(string n, TokenPattern t)
        {
            return new TokenDefinition(n, t, TokenConsumers.ModePopper());
        }
        static public TokenDefinition ModePopper(TokenPattern t)
        {
            return ModePopper(null, t);
        }

        static public TokenDefinition NormalSiT(string n, string sit)
        {
            return Normal(n, TokenPatterns.SiT(sit));
        }
        static public TokenDefinition NormalSiT(string sit)
        {
            return NormalSiT(null, sit);
        }

        static public TokenDefinition IgnoreSiT(string n, string sit)
        {
            return Ignore(n, TokenPatterns.SiT(sit));
        }
        static public TokenDefinition IgnoreSiT(string sit)
        {
            return IgnoreSiT(null, sit);
        }

        static public TokenDefinition ModePusherSiT(string n, string sit, TokenMode m)
        {
            return ModePusher(n, TokenPatterns.SiT(sit), m);
        }
        static public TokenDefinition ModePusherSiT(string sit, TokenMode m)
        {
            return ModePusherSiT(null, sit, m);
        }

        static public TokenDefinition ModePopperSiT(string n, string sit)
        {
            return ModePopper(n, TokenPatterns.SiT(sit));
        }
        static public TokenDefinition ModePopperSiT(string sit)
        {
            return ModePopperSiT(null, sit);
        }
    }
}