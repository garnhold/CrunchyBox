using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    
    static public class GamepadComponentButtonExtensions_Released
    {
        static public bool IsButtonReleasedTapped(this GamepadComponent_Button item, float max_duration)
        {
            if (item.IsButtonReleased())
            {
                if (item.GetHistory().GetPreviousEvent().GetDuration() <= max_duration)
                    return true;
            }

            return false;
        }

        static public bool IsButtonReleasedHeld(this GamepadComponent_Button item, float min_duration)
        {
            if (item.IsButtonReleased())
            {
                if (item.GetHistory().GetPreviousEvent().GetDuration() >= min_duration)
                    return true;
            }

            return false;
        }

        static public bool IsButtonReleasedNTapped(this GamepadComponent_Button item, int count, float max_duration)
        {
            int double_count = count * 2 - 1;

            if (item.IsButtonReleased())
            {
                if (item.GetHistory().GetNumberPastEvents() >= double_count)
                {
                    if (item.GetHistory().GetPastEvents(double_count).AreAll(e => e.GetDuration() <= max_duration))
                        return true;
                }
            }

            return false;
        }
    }
}