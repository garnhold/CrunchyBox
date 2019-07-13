using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public interface InputDeviceEventHistory<T>
    {
        int GetNumberPastEvents();

        InputDeviceEvent<T> GetCurrentEvent();
        IEnumerable<InputDeviceEvent<T>> GetPastEvents(int count);
    }
}