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

        static public ConductorOrder Order_FlickerValue<T>(this ConductedValue<T> item, T first, T second)
        {
            return new ConductorOrder_Multiple_Sequential(
                item.Order_SetValue(first),
                item.Order_WaitForNextUpdate(),
                item.Order_SetValue(second)
            );
        }
        static public ConductorOrder Order_FlickerValue<T>(this ConductedValue<T> item, T value)
        {
            T old_value = default(T);

            return new ConductorOrder_Multiple_Sequential(
                new ConductorOrder_Do(() => {
                    old_value = item.GetValue();
                    item.SetValue(value);
                }),
                item.Order_WaitForNextUpdate(),
                item.Order_SetValue(() => old_value)
            );
        }
    }
}
