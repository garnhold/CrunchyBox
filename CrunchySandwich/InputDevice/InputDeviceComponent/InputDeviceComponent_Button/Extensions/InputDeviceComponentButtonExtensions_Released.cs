using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class InputDeviceComponentButtonExtensions_Released
    {
        static public bool IsButtonReleasedTapped(this InputDeviceComponent_Button item, float max_duration)
        {
            if (item.IsButtonReleased())
            {
                if (item.GetRecentButtonPress().GetDuration() <= max_duration)
                    return true;
            }

            return false;
        }

        static public bool IsButtonReleasedHeld(this InputDeviceComponent_Button item, float min_duration)
        {
            if (item.IsButtonReleased())
            {
                if (item.GetRecentButtonPress().GetDuration() >= min_duration)
                    return true;
            }

            return false;
        }

        static public bool IsButtonReleasedNTapped(this InputDeviceComponent_Button item, int count, float max_duration)
        {
            if (item.IsButtonReleased())
            {
                if (item.GetNumberRecentButtonPresses() >= count)
                {
                    if (item.GetRecentButtonPresses(count).GetFirst().GetTimeSince() <= max_duration)
                        return true;
                }
            }

            return false;
        }
    }
}