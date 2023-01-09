using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public partial struct SheetBound
    {
        public readonly int? column_index;
        public readonly int? row_index;

        static public bool operator ==(SheetBound left, SheetBound right)
        {
            if (left.column_index == right.column_index)
            {
                if (left.row_index == right.row_index)
                    return true;
            }

            return false;
        }
        static public bool operator !=(SheetBound left, SheetBound right)
        {
            if (left == right)
                return false;

            return true;
        }

        public SheetBound(int? c, int? r)
        {
            column_index = c;
            row_index = r;
        }

        public override bool Equals(object obj)
        {
            SheetBound bound;

            if (obj.Convert<SheetBound>(out bound))
                return this == bound;

            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + column_index.GetHashCodeEX();
                hash = hash * 23 + row_index.GetHashCodeEX();
                return hash;
            }
        }
    }
}