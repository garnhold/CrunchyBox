using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    public class GamepadAction_Stick_Gesture : GamepadAction_Stick
    {
        [SerializeField]private GamepadStickGesture gesture;

        protected override bool IsOccuringThisFrameInternal(GamepadComponent_Stick stick)
        {
            if (stick.IsStickGestureOccuringThisFrame(gesture))
                return true;

            return false;
        }

        public GamepadStickGesture GetStickGesture()
        {
            return gesture;
        }
    }
}