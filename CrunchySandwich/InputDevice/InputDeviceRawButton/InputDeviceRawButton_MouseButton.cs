using System;
using System.Collections;
using System.Collections.Generic;

using OpenTK.Input;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    public class InputDeviceRawButton_MouseButton : InputDeviceRawButton
    {
        private int device_index;
        private MouseButton button;

        public InputDeviceRawButton_MouseButton(int di, MouseButton b)
        {
            device_index = di;
            button = b;
        }

        public InputDeviceRawButton_MouseButton(MouseButton b) : this(-1, b) { }

        public override bool UpdateIsButtonDown()
        {
            return MouseExtensions.GetState(device_index).IsButtonDown(button);
        }
    }
}