using System;
using System.Collections;
using System.Collections.Generic;

using OpenTK.Input;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    public class InputDeviceRawButton_JoystickButton : InputDeviceRawButton
    {
        private int device_index;
        private int button_index;

        public InputDeviceRawButton_JoystickButton(int di, int bi)
        {
            device_index = di;
            button_index = bi;
        }

        public override bool UpdateIsButtonDown()
        {
            return JoystickExtensions.GetState(device_index).IsButtonDown(button_index);
        }
    }
}