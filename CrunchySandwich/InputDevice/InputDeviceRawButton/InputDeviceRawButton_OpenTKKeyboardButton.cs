using System;
using System.Collections;
using System.Collections.Generic;

using OpenTK.Input;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class InputDeviceRawButton_OpenTKKeyboardButton : InputDeviceRawButton
    {
        private int device_index;
        private Key key;

        public InputDeviceRawButton_OpenTKKeyboardButton(int di, Key k)
        {
            device_index = di;
            key = k;
        }

        public InputDeviceRawButton_OpenTKKeyboardButton(Key k) : this(-1, k) { }

        public override bool IsButtonDown()
        {
            if (device_index == -1)
                return Keyboard.GetState().IsKeyDown(key);

            return Keyboard.GetState(device_index).IsKeyDown(key);
        }
    }
}