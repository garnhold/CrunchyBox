using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ConductedValueExtensions_DelayedRepeatFlicker
    {
        static public IEnumerable<ConductorOrder> InternalOrder_DelayedRepeatFlicker<T>(ConductedValue<T> item, T first, T second, Timer delay_timer, Timer repeat_timer)
        {
            yield return item.Order_FlickerValue(first, second);
            yield return item.Order_WaitFor(delay_timer);

            while (true)
            {
                yield return item.Order_FlickerValue(first, second);
                yield return item.Order_WaitFor(repeat_timer);
            }
        }
        static public ConductorOrder Order_DelayedRepeatFlicker<T>(this ConductedValue<T> item, T first, T second, Timer delay_timer, Timer repeat_timer)
        {
            return new ConductorOrder_Conductor(InternalOrder_DelayedRepeatFlicker(item, first, second, delay_timer, repeat_timer));
        }
    }
}
