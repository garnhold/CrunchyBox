using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    
    static public class GamepadEventHistoryExtensions_Values
    {
        static public T GetCurrentValue<T>(this GamepadEventHistory<T> item)
        {
            return item.GetCurrentEvent().IfNotNull(e => e.GetValue());
        }

        static public T GetPreviousValue<T>(this GamepadEventHistory<T> item)
        {
            return item.GetPreviousEvent().IfNotNull(e => e.GetValue());
        }

        static public IEnumerable<T> GetPastValues<T>(this GamepadEventHistory<T> item, int count)
        {
            return item.GetPastEvents(count).Convert(e => e.GetValue());
        }

        static public IEnumerable<T> GetCurrentAndPastValues<T>(this GamepadEventHistory<T> item, int count)
        {
            return item.GetCurrentAndPastEvents(count).Convert(e => e.GetValue());
        }
    }
}