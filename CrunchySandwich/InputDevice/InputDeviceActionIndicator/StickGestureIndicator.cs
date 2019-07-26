using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class StickGestureIndicator : MonoBehaviourEX
    {
        public abstract void Initialize(InputDeviceAction_StickGesture action);
    }
}