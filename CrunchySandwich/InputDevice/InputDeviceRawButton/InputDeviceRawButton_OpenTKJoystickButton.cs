using System;
using System.Collections;
using System.Collections.Generic;

using OpenTK.Input;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class InputDeviceRawButton_OpenTKJoystickButton : InputDeviceRawButton
    {
        private int device_index;
        private int button_index;

        public InputDeviceRawButton_OpenTKJoystickButton(int di, int bi)
        {
            device_index = di;
            button_index = bi;
        }

        public override bool IsButtonDown()
        {
            return Joystick.GetState(device_index).IsButtonDown(button_index);
        }
    }
}