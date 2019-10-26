using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceAction_Button_Hold : InputDeviceAction_Button
    {
        protected override bool IsOccuringThisFrameInternal(InputDeviceComponent_Button button)
        {
            if (button.IsButtonDown())
                return true;

            return false;
        }
    }
}