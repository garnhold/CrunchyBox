using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    static public class StringExtensions_ProgrammingKeyword
    {
        static private HashSet<string> RESERVED_KEYWORDS = new HashSet<string>(new string[] {
            "abstract", "add", "as", "ascending", "async", "await", "base", "bool", "break", 
            "by", "byte", "case", "catch", "char", "checked", "class", "const", "continue", 
            "decimal", "default", "delegate", "descending", "do", "double", "dynamic", "else", 
            "enum", "equals", "explicit", "extern", "false", "finally", "fixed", "float", 
            "for", "foreach", "from", "get", "global", "goto", "group", "if", "implicit", "in", 
            "int", "interface", "internal", "into", "is", "join", "let", "lock", "long", 
            "namespace", "new", "null", "object", "on", "operator", "orderby", "out", "override", 
            "params", "partial", "private", "protected", "public", "readonly", "ref", "remove", 
            "return", "sbyte", "sealed", "select", "set", "short", "sizeof", "stackalloc", 
            "static", "string", "struct", "switch", "this", "throw", "true", "try", "typeof", 
            "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "value", "var", "virtual", 
            "void", "volatile", "where", "while", "yield"
        });

        static public bool IsReservedKeyword(this string item)
        {
            if (RESERVED_KEYWORDS.Contains(item))
                return true;

            return false;
        }
    }
}