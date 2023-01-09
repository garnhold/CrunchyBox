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
        static public string ConvertIndexToR1(int index)
        {
            return (index + 1).ToString();
        }

        public string ToR1()
        {
            if (column_index != null && row_index != null)
                return "R" + ConvertIndexToR1(row_index.Solidify()) + "C" + ConvertIndexToR1(column_index.Solidify());

            if (column_index != null)
                return "C" + ConvertIndexToR1(column_index.Solidify());

            if (row_index != null)
                return "R" + ConvertIndexToR1(row_index.Solidify());

            return null;
        }
    }
}