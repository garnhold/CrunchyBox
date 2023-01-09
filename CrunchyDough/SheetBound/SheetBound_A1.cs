using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public partial struct SheetBound
    {
        static public bool TryParseA1(string bound, out SheetBound sheet_bound)
        {
            string column;
            string row;

            bound.RegexPartOut("\\s*([A-Z]*)\\s*([0-9]*)\\s*", out column, out row);

            int column_index;
            int row_index;

            bool has_column = column.IsVisible();
            bool has_row = row.IsVisible();

            if (has_column && has_row)
            {
                if (TryConvertAAAToIndex(column, out column_index))
                {
                    if (TryConvertR1ToIndex(row, out row_index))
                    {
                        sheet_bound = new SheetBound(column_index, row_index);
                        return true;
                    }
                }
            }
            else if (has_column)
            {
                if (TryConvertAAAToIndex(column, out column_index))
                {
                    sheet_bound = new SheetBound(column_index, null);
                    return true;
                }
            }
            else if (has_row)
            {
                if (TryConvertR1ToIndex(row, out row_index))
                {
                    sheet_bound = new SheetBound(null, row_index);
                    return true;
                }
            }

            sheet_bound = new SheetBound();
            return false;
        }

        static public bool TryConvertAAAToIndex(string aaa, out int index)
        {
            int total = 0;

            int power = 1;
            foreach (char a in aaa.Reverse())
            {
                int value = a.GetAlphabetIndex() + 1;

                if (value == 0)
                {
                    index = -1;
                    return false;
                }

                total += value * power;
                power *= 26;
            }

            index = total - 1;
            return true;
        }
        static public bool TryConvertIndexToAAA(int index, out string aaa)
        {
            StringBuilder builder = new StringBuilder();

            index += 1;
            while (index > 0)
            {
                builder.Append('A' + ((index % 26) - 1));

                index /= 26;
            }

            aaa = builder.ToString().Reverse();
            return true;
        }
    }
}