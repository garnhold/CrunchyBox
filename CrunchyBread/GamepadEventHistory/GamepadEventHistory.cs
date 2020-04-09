using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    
    public interface GamepadEventHistory<T>
    {
        int GetNumberPastEvents();

        GamepadEvent<T> GetCurrentEvent();
        IEnumerable<GamepadEvent<T>> GetPastEvents(int count);
    }
}