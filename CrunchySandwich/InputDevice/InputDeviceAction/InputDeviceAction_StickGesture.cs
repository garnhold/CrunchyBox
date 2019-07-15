using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceAction_StickGesture<ALL, AXIS, BUTTON, STICK> : InputDeviceAction<ALL, AXIS, BUTTON, STICK>
    {
        [SerializeField]private STICK stick;
        [SerializeField]private InputDeviceStickGesture gesture;

        public override bool IsOccuringThisFrame(InputDevice<ALL, AXIS, BUTTON, STICK> device)
        {
            if(device.GetStick(stick).IsStickGestureOccuringThisFrame(gesture))
                return true;

            return false;
        }
    }
}