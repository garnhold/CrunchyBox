using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class InputDeviceRawOption_Button<T> : InputDeviceRawOption<T>
    {
        private T value;
        private InputDeviceRawButton button;

        public InputDeviceRawOption_Button(T v, InputDeviceRawButton b)
        {
            value = v;
            button = b;
        }

        public override T GetValue()
        {
            return value;
        }

        public override bool IsSelected()
        {
            if (button.IsButtonDown())
                return true;

            return false;
        }
    }
}