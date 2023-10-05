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

        static public TokenPattern Character(char character)
        {
            return new TokenPattern_Character_Single(character);
        }

        static public TokenPattern String(string s)
        {
            return new TokenPattern_String(s);
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

        static private TokenPattern ALPHABETICAL = Any(LOWERCASE, UPPERCASE);
        static public TokenPattern Alphabetical()
        {
            return ALPHABETICAL;
        }

        static private TokenPattern ALPHANUMERIC = Any(ALPHABETICAL, NUMBER);
        static public TokenPattern AlphaNumeric()
        {
            return ALPHANUMERIC;
        }

        static private TokenPattern ALPHABETICAL_AND_UNDERSCORE = Any(ALPHABETICAL, Character('_'));
        static public TokenPattern AlphabeticalAndUnderscore()
        {
            return ALPHABETICAL_AND_UNDERSCORE;
        }

        static private TokenPattern ALPHANUMERIC_AND_UNDERSCORE = Any(ALPHANUMERIC, Character('_'));
        static public TokenPattern AlphaNumericAndUnderscore()
        {
            return ALPHANUMERIC_AND_UNDERSCORE;
        }

        static private TokenPattern WHITESPACE = CharacterSet(' ', '\t', '\n', '\r');
        static public TokenPattern Whitespace()
        {
            return WHITESPACE;
        }
    }
}