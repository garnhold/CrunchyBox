using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    static public class StringExtensions_ProgrammingKeyword
    {
        static private HashSet<string> RESERVED_KEYWORDS = new HashSet<string>(new string[] {
            "abstract", "as", "bool", "break", 
            "byte", "case", "catch", "char", "checked", "class", "const", "continue", 
            "decimal", "default", "delegate", "do", "double", "else", 
            "enum", "explicit", "extern", "false", "finally", "fixed", "float", 
            "for", "foreach", "goto", "if", "implicit", 
            "int", "interface", "internal", "is", "lock", "long", 
            "namespace", "new", "null", "object", "operator", "out", "override", 
            "params", "private", "protected", "public", "readonly", "ref", 
            "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", 
            "static", "string", "struct", "switch", "this", "throw", "true", "try", "typeof", 
            "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "virtual", 
            "void", "volatile", "while"
        });

        static public bool IsReservedKeyword(this string item)
        {
            if (RESERVED_KEYWORDS.Contains(item))
                return true;

            return false;
        }
    }
}