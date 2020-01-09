using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class InputDeviceEventLog<T> : InputDeviceEventHistory<T>
    {
        private InputDeviceEvent<T> current_event;
        private CircularStack<InputDeviceEvent<T>> past_events;

        public InputDeviceEventLog(int size)
        {
            current_event = new InputDeviceEvent<T>();
            past_events = new CircularStack<InputDeviceEvent<T>>(size);
        }

        public bool LogValue(T value)
        {
            if (current_event.GetValue().NotEqualsEX(value))
            {
                current_event.End();
                past_events.Advance(current_event);

                current_event = new InputDeviceEvent<T>(value);
                current_event.Start();

                return true;
            }

            current_event.Update();
            return false;
        }

        public int GetNumberPastEvents()
        {
            return past_events.Count;
        }

        public InputDeviceEvent<T> GetCurrentEvent()
        {
            return current_event;
        }

        public IEnumerable<InputDeviceEvent<T>> GetPastEvents(int count)
        {
            count = count.Min(past_events.Count);

            for (int i = count - 1; i >= 0; i--)
                yield return past_events[i];
        }
    }
}