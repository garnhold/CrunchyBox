using System;
using System.Collections;
using System.Collections.Generic;

using OpenTK.Input;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    public class InputDeviceRawButton_KeyboardButton : InputDeviceRawButton
    {
        private int device_index;
        private Key key;

        public InputDeviceRawButton_KeyboardButton(int di, Key k)
        {
            device_index = di;
            key = k;
        }

        public InputDeviceRawButton_KeyboardButton(Key k) : this(-1, k) { }

        public override bool IsButtonDown()
        {
            return KeyboardExtensions.GetState(device_index).IsKeyDown(key);
        }
    }
}