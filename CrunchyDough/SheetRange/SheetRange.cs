using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public partial struct SheetRange
    {
        public readonly string sheet_name;

        public readonly SheetBound first;
        public readonly SheetBound last;

        static public SheetRange CreateCell(int column_index, int row_index, string sheet_name=null)
        {
            return new SheetRange(
                sheet_name,
                new SheetBound(column_index, row_index)
            );
        }

        static public SheetRange CreateRange(int first_column_index, int first_row_index, int last_column_index, int last_row_index, string sheet_name = null)
        {
            return new SheetRange(
                sheet_name,
                new SheetBound(first_column_index, first_row_index),
                new SheetBound(last_column_index, last_row_index)
            );
        }

        static public SheetRange CreateRow(int row_index, string sheet_name=null)
        {
            return new SheetRange(
                sheet_name,
                new SheetBound(null, row_index)
            );
        }
        static public SheetRange CreateRowRange(int first_row_index, int last_row_index, string sheet_name=null)
        {
            return new SheetRange(
                sheet_name,
                new SheetBound(null, first_row_index),
                new SheetBound(null, last_row_index)
            );
        }

        static public SheetRange CreateColumn(int column_index, string sheet_name=null)
        {
            return new SheetRange(
                sheet_name,
                new SheetBound(column_index, null)
            );
        }
        static public SheetRange CreateColumnRange(int first_column_index, int last_column_index, string sheet_name=null)
        {
            return new SheetRange(
                sheet_name,
                new SheetBound(first_column_index, null),
                new SheetBound(last_column_index, null)
            );
        }

        static public bool TryParseGeneral(string input, TryOperation<SheetBound, string> operation, out SheetRange sheet_range)
        {
            string sheet_name;
            string bounds;

            input.SplitAtLastIndexOf("!", out sheet_name, out bounds);

            string start_bound;
            string end_bound;

            SheetBound start;
            SheetBound end;

            if (bounds.TrySplitAtIndexOf(":", out start_bound, out end_bound))
            {
                if (operation(start_bound, out start))
                {
                    if (operation(end_bound, out end))
                    {
                        sheet_range = new SheetRange(sheet_name, start, end);
                        return true;
                    }
                }
            }
            else
            {
                if (operation(bounds, out start))
                {
                    sheet_range = new SheetRange(sheet_name, start);
                    return true;
                }
            }

            sheet_range = new SheetRange();
            return false;
        }

        static public bool operator ==(SheetRange left, SheetRange right)
        {
            if (left.sheet_name == right.sheet_name)
            {
                if (left.first == right.first)
                {
                    if (left.last == right.last)
                        return true;
                }
            }

            return false;
        }
        static public bool operator !=(SheetRange left, SheetRange right)
        {
            if (left == right)
                return false;

            return true;
        }

        public SheetRange(string sn, SheetBound f, SheetBound l)
        {
            sheet_name = sn.CoalesceBlankToNull();

            first = f;
            last = l;
        }

        public SheetRange(string sn, SheetBound s) : this(sn, s, s) { }

        public bool HasExplicitSheetName()
        {
            if (sheet_name != null)
                return true;

            return false;
        }

        public override bool Equals(object obj)
        {
            SheetRange range;

            if (obj.Convert<SheetRange>(out range))
                return this == range;

            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + sheet_name.GetHashCodeEX();
                hash = hash * 23 + first.GetHashCodeEX();
                hash = hash * 23 + last.GetHashCodeEX();
                return hash;
            }
        }
    }
}