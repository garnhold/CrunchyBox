using System;
using System.Text;
using System.Text.RegularExpressions;

using CrunchyDough;

namespace CrunchySalt
{
    static public class StringExtensions_ProgrammingLiteral_Style
    {
        static public string StyleAsLiteral(this string item)
        {
            return item;
        }

        static public string StyleAsLiteralByte(this string item)
        {
            return item.ParseByte().ToString().StyleAsLiteral();
        }
        static public string StyleAsLiteralLong(this string item)
        {
            return item.ParseLong().ToString().StyleAsLiteral();
        }

        static public string StyleAsLiteralDouble(this string item)
        {
            return item.ParseDouble().ToString().StyleAsLiteral();
        }

        static public string StyleAsLiteralString(this string item)
        {
            return item.CompressEscapeSequences().Surround("\"").StyleAsLiteral();
        }

        static public string StyleAsLiteralSingleQuoteString(this string item)
        {
            return item.CompressEscapeSequences().Surround("'").StyleAsLiteral();
        }
    }
}