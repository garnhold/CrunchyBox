using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public partial struct SheetBound
    {
        static public bool TryParseR1C1(string bound, out SheetBound sheet_bound)
        {
            string row;
            string column;

            if (bound.RegexPartOut("\\s*R\\s*([0-9]+)\\s*C\\s*([0-9]+)\\s*", out row, out column) == 2)
            {
                int row_index;
                int column_index;

                if (TryConvertR1ToIndex(row, out row_index))
                {
                    if (TryConvertR1ToIndex(column, out column_index))
                    {
                        sheet_bound = new SheetBound(column_index, row_index);
                        return true;
                    }
                }
            }

            sheet_bound = new SheetBound();
            return false;
        }

        static public bool TryConvertR1ToIndex(string r1, out int index)
        {
            if (r1.TryParseInt(out index))
            {
                index--;
                return true;
            }

            index = -1;
            return false;

        }
        static public bool TryConvertIndexToR1(int index, out string r1)
        {
            r1 = (index + 1).ToString();
            return true;
        }
    }
}