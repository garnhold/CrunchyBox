using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class InputDeviceAction_Button_Release : InputDeviceAction_Button
    {
        protected override bool IsOccuringThisFrameInternal(InputDeviceComponent_Button button)
        {
            if (button.IsButtonReleased())
                return true;

            return false;
        }
    }
}