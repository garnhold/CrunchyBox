using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class InputDeviceComponentStickExtensions_StickGesture
    {
        static public bool IsStickGestureOccuringThisFrame(this InputDeviceComponent_Stick item, InputDeviceStickGesture gesture)
        {
            return item.GetHistory().IsStickGestureOccuringThisFrame(gesture);
        }
    }
}