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
            public class ClauseType_FullText : ClauseType<string>
            {
                static public readonly ClauseType_FullText Contains = new ClauseType_FullText("?FIELD contains ?VALUE");

                private ClauseType_FullText(string l) : base(l, v => v.StyleAsLiteralSingleQuoteString()) { }
            }
        }
    }
}