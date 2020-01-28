using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectI2Extensions_Compare
    {
        static public bool IsCollapsed(this RectI2 item)
        {
            if (item.GetWidth() <= 0)
                return true;

            if (item.GetHeight() <= 0)
                return true;

            return false;
        }
    }
}