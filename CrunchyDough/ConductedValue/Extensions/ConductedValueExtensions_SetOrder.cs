using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ConductedValueExtensions_SetOrder
    {
        static public void SetOrder<T>(this ConductedValue<T> item, IEnumerable<ConductorOrder> orders)
        {
            item.SetOrder(new ConductorOrder_Sequential(orders));
        }
        static public void SetOrder<T>(this ConductedValue<T> item, Operation<IEnumerable<ConductorOrder>> operation)
        {
            item.SetOrder(new ConductorOrder_Sequential(operation));
        }
        static public void SetOrder<T>(this ConductedValue<T> item, Operation<IEnumerable<ConductorOrder>, ConductedValue<T>> operation)
        {
            item.SetOrder(new ConductorOrder_Sequential(operation(item)));
        }
    }
}
