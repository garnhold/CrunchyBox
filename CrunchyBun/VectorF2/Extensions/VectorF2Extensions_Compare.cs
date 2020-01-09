using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    using Noodle;
    
    static public class VectorF2Extensions_Compare
    {
        static public bool IsZero(this VectorF2 item)
        {
            if (item.x == 0.0f && item.y == 0.0f)
                return true;

            return false;
        }

        static public bool IsNonZero(this VectorF2 item)
        {
            if (item.IsZero() == false)
                return true;

            return false;
        }
    }
}