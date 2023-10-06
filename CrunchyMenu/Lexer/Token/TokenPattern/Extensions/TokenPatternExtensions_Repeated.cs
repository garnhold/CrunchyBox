using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    static public class TokenPatternExtensions_Repeated
    {
        static public TokenPattern MakeRepeated(this TokenPattern item, int min, int max)
        {
            return new TokenPattern_Repeated(item, min, max);
        }

        static public TokenPattern MakeOptional(this TokenPattern item)
        {
            return item.MakeRepeated(0, 1);
        }

        static public TokenPattern MakeZeroOrMore(this TokenPattern item)
        {
            return item.MakeRepeated(0, int.MaxValue);
        }

        static public TokenPattern MakeOneOrMore(this TokenPattern item)
        {
            return item.MakeRepeated(1, int.MaxValue);
        }
    }
}