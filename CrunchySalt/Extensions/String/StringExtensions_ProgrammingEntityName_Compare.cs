using System;
using System.Text;
using System.Text.RegularExpressions;

using CrunchyDough;

namespace CrunchySalt
{
    static public class StringExtensions_ProgrammingEntityName_Compare
    {
        static public bool IsStyledAsEntity(this string item)
        {
            if (item.RegexIsMatch("^[A-Za-z_][A-Za-z0-9_]*$"))
                return true;

            return false;
        }
    }
}