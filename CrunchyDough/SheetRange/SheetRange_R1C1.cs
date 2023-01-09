using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public partial struct SheetRange
    {
        static public bool TryParseR1C1(string input, out SheetRange sheet_range)
        {
            return TryParseGeneral(
                input,
                (string s, out SheetBound b) => SheetBound.TryParseR1C1(s, out b),
                out sheet_range
            );
        }
    }
}