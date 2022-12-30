using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class R1C1Extensions_Shape
    {
        static public int GetWidth(this R1C1 item)
        {
            return (item.last_column - item.first_column) + 1;
        }
        static public int GetHeight(this R1C1 item)
        {
            return (item.last_row - item.first_row) + 1;
        }
        static public int GetArea(this R1C1 item)
        {
            return item.GetWidth() * item.GetHeight();
        }

        static public bool IsCell(this R1C1 item)
        {
            if (item.first_row == item.last_row && item.first_column == item.last_column)
                return true;

            return false;
        }
        static public bool IsRange(this R1C1 item)
        {
            if (item.IsCell() == false)
                return true;

            return false;
        }

        static public bool IsRow(this R1C1 item)
        {
            if (item.first_row == item.last_row)
                return true;

            return false;
        }
        static public bool IsColumn(this R1C1 item)
        {
            if (item.first_column == item.last_column)
                return true;

            return false;
        }
    }
}