using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    static public class TokenCharacterSetExtensions_Repeated
    {
        static public TokenPattern MakeRepeated(this TokenCharacterSet item, int min, int max)
        {
            return TokenPatterns.Characters(min, max, item);
        }

        static public TokenPattern MakeSingle(this TokenCharacterSet item)
        {
            return TokenPatterns.SingleCharacter(item);
        }

        static public TokenPattern MakeOptional(this TokenCharacterSet item)
        {
            return TokenPatterns.OptionalCharacter(item);
        }

        static public TokenPattern MakeZeroOrMore(this TokenCharacterSet item)
        {
            return TokenPatterns.ZeroOrMoreCharacters(item);
        }

        static public TokenPattern MakeOneOrMore(this TokenCharacterSet item)
        {
            return TokenPatterns.OneOrMoreCharacters(item);
        }
    }
}