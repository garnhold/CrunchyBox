using System;
using System.Collections;
using System.Collections.Generic;

using System.Globalization;

namespace CrunchyDough
{
    static public class CharExtensions_Category
    {
        static public readonly char[] LINEAR_WHITESPACE = GetChars(
            UnicodeCategory.SpaceSeparator
        ).Append('\t', ' ').Unique().ToArray();

        static public readonly char[] NEWLINE = GetChars(
            UnicodeCategory.LineSeparator,
            UnicodeCategory.ParagraphSeparator
        ).Append('\n', '\r').Unique().ToArray();

        static public readonly char[] WHITESPACE = GetChars(
            c => Char.IsWhiteSpace(c)
        ).ToArray();

        static private IEnumerable<char> GetChars(Predicate<char> predicate)
        {
            List<char> characters = new List<char>();

            for (int i = Char.MinValue; i <= Char.MaxValue; i++)
            {
                char character = (char)i;

                if (predicate.DoesDescribe(character))
                    characters.Add(character);
            }

            return characters;
        }

        static private IEnumerable<char> GetChars(params UnicodeCategory[] categorys)
        {
            return GetChars(c => 
                categorys.Has(category =>
                     Char.GetUnicodeCategory(c) == category
                )
            );
        }

        static public bool IsLinearWhitespace(this char item)
        {
            if (LINEAR_WHITESPACE.Has(item))
                return true;

            return false;
        }

        static public bool IsNewline(this char item)
        {
            if (NEWLINE.Has(item))
                return true;

            return false;
        }

        static public bool IsWhitespace(this char item)
        {
            if (WHITESPACE.Has(item))
                return true;

            return false;
        }
    }
}