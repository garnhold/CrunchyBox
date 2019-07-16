using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceAction_StickGesture : InputDeviceAction
    {
        [SerializeField]private InputDeviceStickId stick;
        [SerializeField]private InputDeviceStickGesture gesture;

        public override bool IsOccuringThisFrame(InputDeviceBase device)
        {
            if(device.GetStick(stick).IsStickGestureOccuringThisFrame(gesture))
                return true;

            return false;
        }
    }
}