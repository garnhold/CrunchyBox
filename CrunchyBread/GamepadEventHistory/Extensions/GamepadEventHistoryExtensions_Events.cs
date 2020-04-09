using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    
    static public class GamepadEventHistoryExtensions_Events
    {
        static public GamepadEvent<T> GetPreviousEvent<T>(this GamepadEventHistory<T> item)
        {
            return item.GetPastEvents(1).GetFirst();
        }

        static public IEnumerable<GamepadEvent<T>> GetCurrentAndPastEvents<T>(this GamepadEventHistory<T> item, int count)
        {
            return item.GetPastEvents(count - 1).Append(item.GetCurrentEvent());
        }
    }
}