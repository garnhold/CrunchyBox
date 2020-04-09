using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    
    public class GamepadEventLog<T> : GamepadEventHistory<T>
    {
        private GamepadEvent<T> current_event;
        private CircularStack<GamepadEvent<T>> past_events;

        public GamepadEventLog(int size)
        {
            current_event = new GamepadEvent<T>();
            past_events = new CircularStack<GamepadEvent<T>>(size);
        }

        public bool LogValue(T value)
        {
            if (current_event.GetValue().NotEqualsEX(value))
            {
                current_event.End();
                past_events.Advance(current_event);

                current_event = new GamepadEvent<T>(value);
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

        public GamepadEvent<T> GetCurrentEvent()
        {
            return current_event;
        }

        public IEnumerable<GamepadEvent<T>> GetPastEvents(int count)
        {
            count = count.Min(past_events.Count);

            for (int i = count - 1; i >= 0; i--)
                yield return past_events[i];
        }
    }
}