using System;
using System.Collections;
using System.Collections.Generic;

using OpenTK.Input;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Button_Native_Joystick : InputAtom_Button_Native
    {
        private int device_index;
        private int button_index;

        public InputAtom_Button_Native_Joystick(int di, int bi)
        {
            device_index = di;
            button_index = bi;
        }

        public override bool GetValue()
        {
            return JoystickExtensions.GetState(device_index).IsButtonDown(button_index);
        }
    }
}