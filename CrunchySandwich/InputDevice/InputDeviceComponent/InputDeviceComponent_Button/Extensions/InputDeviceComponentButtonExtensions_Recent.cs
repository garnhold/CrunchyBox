using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class InputDeviceComponentButtonExtensions_Recent
    {
        static public InputDeviceComponentButtonPress GetRecentButtonPress(this InputDeviceComponent_Button item)
        {
            return item.GetRecentButtonPresses(1).GetFirst();
        }
    }
}