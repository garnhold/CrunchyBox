using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    static public class GamepadEventHistoryExtensions_StickGesture
    {
        static public bool IsStickGestureOccuringThisFrame(this GamepadEventHistory<GamepadStickZone> item, GamepadStickGesture gesture)
        {
            return item.IsEventSequenceOccuringThisFrame(gesture.GetStickZones());
        }
    }
}