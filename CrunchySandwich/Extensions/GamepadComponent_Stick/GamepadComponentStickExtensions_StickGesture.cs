using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;

    static public class GamepadComponentStickExtensions_StickGesture
    {
        static public bool IsStickGestureOccuringThisFrame(this GamepadComponent_Stick item, GamepadStickGesture gesture)
        {
            return item.GetHistory().IsStickGestureOccuringThisFrame(gesture);
        }
    }
}