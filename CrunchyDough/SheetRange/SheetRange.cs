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

        public SheetRange(SheetBound s, SheetBound e) : this(null, s, e) { }
        public SheetRange(SheetBound s) : this(s, s) { }

        public SheetRange(string sn, SheetBound s) : this(sn, s, s) { }

        public SheetRange(string sn, int c1, int r1, int c2, int r2) : this(sn, new SheetBound(c1, r1), new SheetBound(c2, r2)) { }
        public SheetRange(int c1, int r1, int c2, int r2) : this(null, c1, r1, c2, r2) { }

        public SheetRange(string sn, int c1, int r1) : this(sn, c1, r1, c1, r1) { }
        public SheetRange(int c1, int r1) : this(null, c1, r1) { }

        public bool HasExplicitSheetName()
        {
            if (sheet_name != null)
                return true;

            return false;
        }

        public bool IsCell()
        {
            if (first == last)
                return true;

            return false;
        }

        public bool IsRange()
        {
            if (first != last)
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