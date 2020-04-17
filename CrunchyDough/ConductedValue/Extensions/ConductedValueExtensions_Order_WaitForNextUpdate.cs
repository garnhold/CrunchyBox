using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ConductedValueExtensions_Order_WaitForNextUpdate
    {
        static public ConductorOrder Order_WaitForNextUpdate<T>(this ConductedValue<T> item)
        {
            return new ConductorOrder_WaitForNextUpdate();
        }
    }
}
