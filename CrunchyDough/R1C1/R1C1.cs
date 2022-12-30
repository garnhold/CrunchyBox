using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public struct R1C1
    {
        public readonly string sheet_name;

        public readonly int first_row;
        public readonly int first_column;

        public readonly int last_row;
        public readonly int last_column;

        public R1C1(string sn, int r1, int c1, int r2, int c2)
        {
            sheet_name = sn;

            first_row = r1;
            first_column = c1;

            last_row = r2;
            last_column = c2;
        }
        public R1C1(int r1, int c1, int r2, int c2) : this(null, r1, c1, r2, c2) { }

        public R1C1(string sn, int r1, int c1) : this(sn, r1, c1, r1, c1) { }
        public R1C1(int r1, int c1) : this(null, r1, c1) { }

        public override string ToString()
        {
            return this.FormatCompact();
        }
    }
}