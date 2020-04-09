using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    public class GamepadAction_Button_Hold : GamepadAction_Button
    {
        protected override bool IsOccuringThisFrameInternal(GamepadComponent_Button button)
        {
            if (button.IsButtonDown())
                return true;

            return false;
        }
    }
}