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
            public class ClauseType_Bool : ClauseType<bool>
            {
                static public readonly ClauseType_Bool EqualTo = new ClauseType_Bool("?FIELD = ?VALUE");
                static public readonly ClauseType_Bool NotEqualTo = new ClauseType_Bool("?FIELD != ?VALUE");

                private ClauseType_Bool(string l) : base(l, v => v.ToString()) { }
            }
        }
    }
}