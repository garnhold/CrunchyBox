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
            public class ClauseType_Number : ClauseType<int>
            {
                static public readonly ClauseType_Number EqualTo = new ClauseType_Number("?FIELD = ?VALUE");
                static public readonly ClauseType_Number NotEqualTo = new ClauseType_Number("?FIELD != ?VALUE");

                static public readonly ClauseType_Number GreaterThan = new ClauseType_Number("?FIELD > ?VALUE");
                static public readonly ClauseType_Number GreaterThanOrEqualTo = new ClauseType_Number("?FIELD >= ?VALUE");

                static public readonly ClauseType_Number LessThan = new ClauseType_Number("?FIELD < ?VALUE");
                static public readonly ClauseType_Number LessThanOrEqualTo = new ClauseType_Number("?FIELD <= ?VALUE");

                private ClauseType_Number(string l) : base(l, v => v.ToString()) { }
            }
        }
    }
}