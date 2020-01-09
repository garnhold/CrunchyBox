using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class InputDeviceAction_Stick_Gesture : InputDeviceAction_Stick
    {
        [SerializeField]private InputDeviceStickGesture gesture;

        protected override bool IsOccuringThisFrameInternal(InputDeviceComponent_Stick stick)
        {
            if (stick.IsStickGestureOccuringThisFrame(gesture))
                return true;

            return false;
        }

        public InputDeviceStickGesture GetStickGesture()
        {
            return gesture;
        }
    }
}