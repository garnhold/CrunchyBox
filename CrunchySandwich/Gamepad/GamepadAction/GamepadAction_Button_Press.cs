using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    public class GamepadAction_Button_Press : GamepadAction_Button
    {
        protected override bool IsOccuringThisFrameInternal(GamepadComponent_Button button)
        {
            if (button.IsButtonPressed())
                return true;

            return false;
        }
    }
}