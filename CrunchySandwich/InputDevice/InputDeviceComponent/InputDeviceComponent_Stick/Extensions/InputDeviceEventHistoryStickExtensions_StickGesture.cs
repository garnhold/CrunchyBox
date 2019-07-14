using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class InputDeviceEventHistoryStickExtensions_StickGesture
    {
        static public bool IsStickGestureOccuringThisFrame(this InputDeviceEventHistory<InputDeviceStickZone> item, InputDeviceStickGesture gesture)
        {
            return item.IsEventSequenceOccuringThisFrame(gesture.GetStickZones());
        }
    }
}