using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_To
    {
        static public byte[] ToUnicodeBytes(this string item)
        {
            return Encoding.Unicode.GetBytes(item);
        }

        static public byte[] ToAsciiBytes(this string item)
        {
            return Encoding.ASCII.GetBytes(item);
        }
    }
}