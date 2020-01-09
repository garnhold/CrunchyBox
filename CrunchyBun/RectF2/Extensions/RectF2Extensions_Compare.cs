using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class RectF2Extensions_Compare
    {
        static public bool IsCollapsed(this RectF2 item, float tolerance)
        {
            if (item.GetWidth() <= tolerance)
                return true;

            if (item.GetHeight() <= tolerance)
                return true;

            return false;
        }

        static public bool IsCollapsed(this RectF2 item)
        {
            return item.IsCollapsed(0.0f);
        }
    }
}