using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class R1C1Extensions_Format
    {
        static public string FormatFirstAtom(this R1C1 item)
        {
            return "R" + item.first_row + "C" + item.first_column;
        }
        static public string FormatLastAtom(this R1C1 item)
        {
            return "R" + item.last_row + "C" + item.last_column;
        }

        static public string FormatAtomRange(this R1C1 item)
        {
            return item.FormatFirstAtom() + ":" + item.FormatLastAtom();
        }
        static public string FormatCompactAtomRange(this R1C1 item)
        {
            if (item.IsCell())
                return item.FormatFirstAtom();

            return item.FormatAtomRange();
        }

        static public string FormatFull(this R1C1 item)
        {
            if (item.IsExplicitSheet())
                return item.sheet_name + "!" + item.FormatAtomRange();

            return item.FormatAtomRange();
        }
        static public string FormatCompact(this R1C1 item)
        {
            if (item.IsExplicitSheet())
                return item.sheet_name + "!" + item.FormatCompactAtomRange();

            return item.FormatCompactAtomRange();
        }
    }
}