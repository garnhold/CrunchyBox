using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class InputDeviceEventHistoryExtensions_Values
    {
        static public T GetCurrentValue<T>(this InputDeviceEventHistory<T> item)
        {
            return item.GetCurrentEvent().IfNotNull(e => e.GetValue());
        }

        static public T GetPreviousValue<T>(this InputDeviceEventHistory<T> item)
        {
            return item.GetPreviousEvent().IfNotNull(e => e.GetValue());
        }

        static public IEnumerable<T> GetPastValues<T>(this InputDeviceEventHistory<T> item, int count)
        {
            return item.GetPastEvents(count).Convert(e => e.GetValue());
        }

        static public IEnumerable<T> GetCurrentAndPastValues<T>(this InputDeviceEventHistory<T> item, int count)
        {
            return item.GetCurrentAndPastEvents(count).Convert(e => e.GetValue());
        }
    }
}