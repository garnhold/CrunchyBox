using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    static public class TokenPatterns
    {
        static public TokenPattern Sequence(IEnumerable<TokenPattern> patterns)
        {
            return new TokenPattern_Sequence(patterns);
        }
        static public TokenPattern Sequence(params TokenPattern[] patterns)
        {
            return Sequence((IEnumerable<TokenPattern>)patterns);
        }

        static public TokenPattern Any(IEnumerable<TokenPattern> patterns)
        {
            return new TokenPattern_Any(patterns);
        }
        static public TokenPattern Any(params TokenPattern[] patterns)
        {
            return Any((IEnumerable<TokenPattern>)patterns);
        }

        static public TokenPattern String(string s)
        {
            return new TokenPattern_String(s);
        }

        static public TokenPattern Characters(TokenCharacterSet set, int min, int max)
        {
            return new TokenPattern_Characters(set, min, max);
        }
    }
}