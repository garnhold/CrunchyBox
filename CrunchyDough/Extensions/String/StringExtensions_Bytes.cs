using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Bytes
    {
        static public byte[] FromBase64String(this string item)
        {
            return Convert.FromBase64String(item);
        }
    }
}