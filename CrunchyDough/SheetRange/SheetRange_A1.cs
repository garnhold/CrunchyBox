using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public partial struct SheetRange
    {
        static public bool TryParseA1(string input, out SheetRange sheet_range)
        {
            return TryParseGeneral(
                input, 
                (string s, out SheetBound b) => SheetBound.TryParseA1(s, out b), 
                out sheet_range
            );
        }

        public string ToA1()
        {
            string prefix = HasExplicitSheetName()
                .ConvertBool(sheet_name + "!", "");

            if (IsCell())
                return prefix + first.ToA1();

            return prefix + first.ToA1() + ":" + last.ToA1();
        }
    }
}