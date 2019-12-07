using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class InputDeviceEventHistoryExtensions_Events
    {
        static public InputDeviceEvent<T> GetPreviousEvent<T>(this InputDeviceEventHistory<T> item)
        {
            return item.GetPastEvents(1).GetFirst();
        }

        static public IEnumerable<InputDeviceEvent<T>> GetCurrentAndPastEvents<T>(this InputDeviceEventHistory<T> item, int count)
        {
            return item.GetPastEvents(count - 1).Append(item.GetCurrentEvent());
        }
    }
}