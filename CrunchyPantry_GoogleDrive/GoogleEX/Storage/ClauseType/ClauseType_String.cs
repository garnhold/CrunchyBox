using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyPantry_GoogleDrive
{
    namespace GoogleEX
    {
        namespace Storage
        {
            public class ClauseType_String : ClauseType<string>
            {
                static public readonly ClauseType_String EqualTo = new ClauseType_String("?FIELD = ?VALUE");
                static public readonly ClauseType_String NotEqualTo = new ClauseType_String("?FIELD != ?VALUE");
                static public readonly ClauseType_String Contains = new ClauseType_String("?FIELD contains ?VALUE");

                private ClauseType_String(string l) : base(l, v => v.StyleAsLiteralSingleQuoteString()) { }
            }
        }
    }
}