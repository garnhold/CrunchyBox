using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Salt
{
    using Dough;

    static public class StringExtensions_ProgrammingLiteral_Style
    {
        static public string StyleAsLiteral(this bool item)
        {
            return item.ToString().ToLower();
        }
        static public string StyleAsLiteralBool(this string item)
        {
            return item.ParseBool().StyleAsLiteral();
        }

        static public string StyleAsLiteral(this byte item)
        {
            return item.ToString();
        }
        static public string StyleAsLiteralByte(this string item)
        {
            return item.ParseByte().StyleAsLiteral();
        }

        static public string StyleAsLiteral(this short item)
        {
            return item.ToString();
        }
        static public string StyleasLiteralShort(this string item)
        {
            return item.ParseShort().StyleAsLiteral();
        }

        static public string StyleAsLiteral(this int item)
        {
            return item.ToString();
        }
        static public string StyleAsLiteralInt(this string item)
        {
            return item.ParseInt().StyleAsLiteral();
        }

        static public string StyleAsLiteral(this long item)
        {
            return item.ToString() + "L";
        }
        static public string StyleAsLiteralLong(this string item)
        {
            return item.ParseLong().StyleAsLiteral();
        }

        static public string StyleAsLiteral(this float item)
        {
            return item.ToString() + "f";
        }
        static public string StyleAsLiteralFloat(this string item)
        {
            return item.ParseFloat().StyleAsLiteral();
        }

        static public string StyleAsLiteral(this double item)
        {
            return item.ToString();
        }
        static public string StyleAsLiteralDouble(this string item)
        {
            return item.ParseDouble().StyleAsLiteral();
        }

        static public string StyleAsLiteral(this Enum item)
        {
            return item.GetEnumValueInfo().IfNotNull(i => i.GetEnumType().Name + "." + i.GetName());
        }

        static public string StyleAsDoubleQuoteLiteral(this string item)
        {
            return item.CompressEscapeSequences().Surround("\"");
        }

        static public string StyleAsSingleQuoteLiteral(this string item)
        {
            return item.CompressEscapeSequences().Surround("'");
        }
    }
}