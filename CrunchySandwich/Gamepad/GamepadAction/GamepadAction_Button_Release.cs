using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    public class GamepadAction_Button_Release : GamepadAction_Button
    {
        protected override bool IsOccuringThisFrameInternal(GamepadComponent_Button button)
        {
            if (button.IsButtonReleased())
                return true;

            return false;
        }
    }
}