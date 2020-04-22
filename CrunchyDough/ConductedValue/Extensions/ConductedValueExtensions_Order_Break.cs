using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ConductedValueExtensions_Order_Break
    {
        static public ConductorOrder Order_Break<T>(this ConductedValue<T> item)
        {
            return new ConductorOrder_Break();
        }
    }
}
