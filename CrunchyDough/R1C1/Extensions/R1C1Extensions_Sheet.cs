using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class R1C1Extensions_Sheet
    {
        static public bool IsExplicitSheet(this R1C1 item)
        {
            if (item.sheet_name.IsVisible())
                return true;

            return false;
        }
    }
}