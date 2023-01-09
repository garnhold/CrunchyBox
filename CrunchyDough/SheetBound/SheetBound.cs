using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public partial struct SheetBound
    {
        public readonly int? column_index;
        public readonly int? row_index;

        public SheetBound(int? c, int? r)
        {
            column_index = c;
            row_index = r;
        }
    }
}