using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ConductedValueExtensions_Order_Value
    {
        static public ConductorOrder Order_SetValue<T>(this ConductedValue<T> item, Operation<T> operation)
        {
            return new ConductorOrder_Do(() => item.SetValue(operation()));
        }
        static public ConductorOrder Order_SetValue<T>(this ConductedValue<T> item, T value)
        {
            return item.Order_SetValue(() => value);
        }

        static private IEnumerable<ConductorOrder> InternalOrder_FlickerValue<T>(ConductedValue<T> item, T first, T second)
        {
            yield return item.Order_SetValue(first);
            yield return item.Order_WaitForNextUpdate();
            yield return item.Order_SetValue(second);
        }
        static public ConductorOrder Order_FlickerValue<T>(this ConductedValue<T> item, T first, T second)
        {
            return new ConductorOrder_Sequential(InternalOrder_FlickerValue(item, first, second));
        }

        static private IEnumerable<ConductorOrder> InternalOrder_FlickerValue<T>(ConductedValue<T> item, T value)
        {
            T old_value = item.GetValue();

            yield return item.Order_SetValue(value);
            yield return item.Order_WaitForNextUpdate();
            yield return item.Order_SetValue(old_value);
        }
        static public ConductorOrder Order_FlickerValue<T>(this ConductedValue<T> item, T value)
        {
            return new ConductorOrder_Sequential(InternalOrder_FlickerValue(item, value));
        }
    }
}
