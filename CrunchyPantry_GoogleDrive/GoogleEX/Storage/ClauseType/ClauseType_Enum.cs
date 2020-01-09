using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Crunchy.Pantry_GoogleDrive
{
    using Dough;
    using Salt;
    
    namespace GoogleEX
    {
        namespace Storage
        {
            public class ClauseType_Enum : ClauseType<string>
            {
                static public readonly ClauseType_Enum EqualTo = new ClauseType_Enum("?FIELD = ?VALUE");
                static public readonly ClauseType_Enum NotEqualTo = new ClauseType_Enum("?FIELD != ?VALUE");

                private ClauseType_Enum(string l) : base(l, v => v.StyleAsLiteralSingleQuoteString()) { }
            }
        }
    }
}