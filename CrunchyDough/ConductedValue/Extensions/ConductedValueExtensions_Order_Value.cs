using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ConductedValueExtensions_Order_Value
    {
        static public ConductorOrder Order_SetValue<T>(this ConductedValue<T> item, T value)
        {
            return new ConductorOrder_Do(() => item.SetValue(value));
        }

        static public ConductorOrder Order_FlickerValue<T>(this ConductedValue<T> item, T first, T second)
        {
            return new ConductorOrder_Multiple_Sequential(
                item.Order_SetValue(first),
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
                new ConductorOrder_Do(
                    () => item.SetValue(old_value)
                )
            );
        }
    }
}
