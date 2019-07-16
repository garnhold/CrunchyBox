using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceAction_ButtonHold : InputDeviceAction
    {
        [SerializeField]private InputDeviceButtonId button;

        public override bool IsOccuringThisFrame(InputDeviceBase device)
        {
            if (device.GetButton(button).IsButtonDown())
                return true;

            return false;
        }
    }
}