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
            public class ClauseType_Date : ClauseType<DateTime>
            {
                static public readonly ClauseType_Date EqualTo = new ClauseType_Date("?FIELD = ?VALUE");
                static public readonly ClauseType_Date NotEqualTo = new ClauseType_Date("?FIELD != ?VALUE");

                static public readonly ClauseType_Date GreaterThan = new ClauseType_Date("?FIELD > ?VALUE");
                static public readonly ClauseType_Date GreaterThanOrEqualTo = new ClauseType_Date("?FIELD >= ?VALUE");

                static public readonly ClauseType_Date LessThan = new ClauseType_Date("?FIELD < ?VALUE");
                static public readonly ClauseType_Date LessThanOrEqualTo = new ClauseType_Date("?FIELD <= ?VALUE");

                private ClauseType_Date(string l) : base(l, v => v.ToRFC3339().StyleAsLiteralSingleQuoteString()) { }
            }
        }
    }
}