using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceAction_ButtonRelease<ALL, AXIS, BUTTON, STICK> : InputDeviceAction<ALL, AXIS, BUTTON, STICK>
    {
        [SerializeField]private BUTTON button;

        public override bool IsOccuringThisFrame(InputDevice<ALL, AXIS, BUTTON, STICK> device)
        {
            if (device.GetButton(button).IsButtonReleased())
                return true;

            return false;
        }
    }
}