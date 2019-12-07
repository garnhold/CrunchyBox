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
            public class ClauseType_InCollection : ClauseType<string>
            {
                static public readonly ClauseType_InCollection In = new ClauseType_InCollection("?VALUE in ?FIELD");

                private ClauseType_InCollection(string l) : base(l, v => v.StyleAsLiteralSingleQuoteString()) { }
            }
        }
    }
}