using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceEventEmptyHistory<T> : InputDeviceEventHistory<T>
    {
        static public readonly InputDeviceEventEmptyHistory<T> INSTANCE = new InputDeviceEventEmptyHistory<T>();

        private InputDeviceEventEmptyHistory() { }

        public int GetNumberPastEvents()
        {
            return 0;
        }

        public InputDeviceEvent<T> GetCurrentEvent()
        {
            return null;
        }

        public IEnumerable<InputDeviceEvent<T>> GetPastEvents(int count)
        {
            return Empty.IEnumerable<InputDeviceEvent<T>>();
        }
    }
}