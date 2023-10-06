using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    static public class TokenCharacterSets
    {
        static public TokenCharacterSet List(IEnumerable<char> characters)
        {
            return new TokenCharacterSet(characters);
        }
        static public TokenCharacterSet List(params char[] characters)
        {
            return List((IEnumerable<char>)characters);
        }

        static public TokenCharacterSet Single(char character)
        {
            return List(character);
        }

        static public TokenCharacterSet Range(char first, char last)
        {
            return List(Chars.Range(first, last, true));
        }

        static public TokenCharacterSet Combine(IEnumerable<TokenCharacterSet> sets)
        {
            return List(sets.Convert(s => s.GetCharacters()).Flatten());
        }
        static public TokenCharacterSet Combine(params TokenCharacterSet[] sets)
        {
            return Combine((IEnumerable<TokenCharacterSet>)sets);
        }

        static private readonly TokenCharacterSet WHITESPACE = List(' ', '\t', '\n', '\r');
        static public TokenCharacterSet Whitespace()
        {
            return WHITESPACE;
        }

        static private readonly TokenCharacterSet LOWERCASE = Range('a', 'z');
        static public TokenCharacterSet Lowercase()
        {
            return LOWERCASE;
        }

        static private readonly TokenCharacterSet UPPERCASE = Range('A', 'Z');
        static public TokenCharacterSet Uppercase()
        {
            return UPPERCASE;
        }

        static private readonly TokenCharacterSet ALPHABETIC = Combine(LOWERCASE, UPPERCASE);
        static public TokenCharacterSet Alphabetic()
        {
            return ALPHABETIC;
        }

        static private readonly TokenCharacterSet NUMERIC = Range('0', '9');
        static public TokenCharacterSet Numeric()
        {
            return NUMERIC;
        }

        static private readonly TokenCharacterSet ALPHANUMERIC = Combine(ALPHABETIC, NUMERIC);
        static public TokenCharacterSet AlphaNumeric()
        {
            return ALPHANUMERIC;
        }
    }
}