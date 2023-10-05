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

        static public TokenPattern Multiple(IEnumerable<TokenPattern> patterns)
        {
            return new TokenPattern_Multiple(patterns);
        }
        static public TokenPattern Mutliple(params TokenPattern[] patterns)
        {
            return Multiple((IEnumerable<TokenPattern>)patterns);
        }

        static public TokenPattern Character(char character)
        {
            return new TokenPattern_Character_Single(character);
        }

        static public TokenPattern CharacterRange(char first_character, char last_character)
        {
            return new TokenPattern_Character_Range(first_character, last_character);
        }

        static public TokenPattern CharacterSet(IEnumerable<char> characters)
        {
            return new TokenPattern_Character_Set(characters);
        }
        static public TokenPattern CharacterSet(params char[] characters)
        {
            return CharacterSet((IEnumerable<char>)characters);
        }
    }
}