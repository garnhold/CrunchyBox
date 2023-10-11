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

        static public TokenDefinition ModePusher(string n, TokenPattern t, TokenModeInstance m)
        {
            return new TokenDefinition(n, t, TokenConsumers.ModePusher(m));
        }
        static public TokenDefinition ModePusher(TokenPattern t, TokenModeInstance m)
        {
            return ModePusher(null, t, m);
        }

        static public TokenDefinition ModePusher(string n, TokenPattern t, TokenMode s, IEnumerable<TokenDefinition> a)
        {
            return ModePusher(n, t, s.Instance(a));
        }
        static public TokenDefinition ModePusher(TokenPattern t, TokenMode s, IEnumerable<TokenDefinition> a)
        {
            return ModePusher(null, t, s, a);
        }

        static public TokenDefinition ModePusher(string n, TokenPattern t, TokenMode s, params TokenDefinition[] a)
        {
            return ModePusher(n, t, s, (IEnumerable<TokenDefinition>)a);
        }
        static public TokenDefinition ModePusher(TokenPattern t, TokenMode s, params TokenDefinition[] a)
        {
            return ModePusher(null, t, s, a);
        }

        static public TokenDefinition ModePopper(string n, TokenPattern t)
        {
            return new TokenDefinition(n, t, TokenConsumers.ModePopper());
        }
        static public TokenDefinition ModePopper(TokenPattern t)
        {
            return ModePopper(null, t);
        }
    }
}