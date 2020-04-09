using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    
    public class GamepadEventEmptyHistory<T> : GamepadEventHistory<T>
    {
        static public readonly GamepadEventEmptyHistory<T> INSTANCE = new GamepadEventEmptyHistory<T>();

        private GamepadEventEmptyHistory() { }

        public int GetNumberPastEvents()
        {
            return 0;
        }

        public GamepadEvent<T> GetCurrentEvent()
        {
            return null;
        }

        public IEnumerable<GamepadEvent<T>> GetPastEvents(int count)
        {
            return Empty.IEnumerable<GamepadEvent<T>>();
        }
    }
}