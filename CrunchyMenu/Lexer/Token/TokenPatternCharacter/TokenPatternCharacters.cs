using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    static public class TokenPatternCharacters
    {
        static public TokenPatternCharacter Single(char character, int min, int max)
        {
            return new TokenPatternCharacter_Single(character, min, max);
        }

        static public TokenPatternCharacter Multiple(IEnumerable<char> characters, int min, int max)
        {
            return new TokenPatternCharacter_Multiple(characters, min, max);
        }
        static public TokenPatternCharacter Multiple(int min, int max, params char[] characters)
        {
            return Multiple((IEnumerable<char>)characters, min, max);
        }

        static public TokenPatternCharacter Range(char first, char last, int min, int max)
        {
            return new TokenPatternCharacter_Range(first, last, min, max);
        }
    }
}