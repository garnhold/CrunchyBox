using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public interface InputDeviceEventHistory<T>
    {
        int GetNumberPastEvents();

        InputDeviceEvent<T> GetCurrentEvent();
        IEnumerable<InputDeviceEvent<T>> GetPastEvents(int count);
    }
}