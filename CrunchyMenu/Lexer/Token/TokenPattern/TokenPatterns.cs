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

        static public TokenPattern Characters(IEnumerable<TokenCharacterSet> sets, int min, int max)
        {
            return new TokenPattern_Characters(TokenCharacterSets.Combine(sets), min, max);
        }
        static public TokenPattern Characters(int min, int max, params TokenCharacterSet[] sets)
        {
            return Characters((IEnumerable<TokenCharacterSet>)sets, min, max);
        }

        static public TokenPattern SingleCharacter(IEnumerable<TokenCharacterSet> sets)
        {
            return Characters(sets, 1, 1);
        }
        static public TokenPattern SingleCharacter(params TokenCharacterSet[] sets)
        {
            return SingleCharacter((IEnumerable<TokenCharacterSet>)sets);
        }

        static public TokenPattern OptionalCharacter(IEnumerable<TokenCharacterSet> sets)
        {
            return Characters(sets, 0, 1);
        }
        static public TokenPattern OptionalCharacter(params TokenCharacterSet[] sets)
        {
            return OptionalCharacter((IEnumerable<TokenCharacterSet>)sets);
        }

        static public TokenPattern OneOrMoreCharacters(IEnumerable<TokenCharacterSet> sets)
        {
            return Characters(sets, 1, int.MaxValue);
        }
        static public TokenPattern OneOrMoreCharacters(params TokenCharacterSet[] sets)
        {
            return OneOrMoreCharacters((IEnumerable<TokenCharacterSet>)sets);
        }

        static public TokenPattern ZeroOrMoreCharacters(IEnumerable<TokenCharacterSet> sets)
        {
            return Characters(sets, 0, int.MaxValue);
        }
        static public TokenPattern ZeroOrMoreCharacters(params TokenCharacterSet[] sets)
        {
            return ZeroOrMoreCharacters((IEnumerable<TokenCharacterSet>)sets);
        }

        static public TokenPattern Junk()
        {
            return TokenPattern_Junk.INSTANCE;
        }
    }
}