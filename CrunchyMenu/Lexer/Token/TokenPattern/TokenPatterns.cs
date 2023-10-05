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

        static private TokenPattern NUMBER = CharacterRange('0', '9');
        static public TokenPattern Number()
        {
            return NUMBER;
        }

        static private TokenPattern LOWERCASE = CharacterRange('a', 'z');
        static public TokenPattern Lowercase()
        {
            return LOWERCASE;
        }

        static private TokenPattern UPPERCASE = CharacterRange('A', 'Z');
        static public TokenPattern Uppercase()
        {
            return UPPERCASE;
        }

        static private TokenPattern ALPHABETICAL = Multiple(LOWERCASE, UPPERCASE);
        static public TokenPattern Alphabetical()
        {
            return ALPHABETICAL;
        }

        static private TokenPattern ALPHANUMERIC = Multiple(ALPHABETICAL, NUMBER);
        static public TokenPattern AlphaNumeric()
        {
            return ALPHANUMERIC;
        }

        static private TokenPattern ALPHABETICAL_AND_UNDERSCORE = Multiple(ALPHABETICAL, Character('_'));
        static public TokenPattern AlphabeticalAndUnderscore()
        {
            return ALPHABETICAL_AND_UNDERSCORE;
        }

        static private TokenPattern ALPHANUMERIC_AND_UNDERSCORE = Multiple(ALPHANUMERIC, Character('_'));
        static public TokenPattern AlphaNumericAndUnderscore()
        {
            return ALPHANUMERIC_AND_UNDERSCORE;
        }
    }
}