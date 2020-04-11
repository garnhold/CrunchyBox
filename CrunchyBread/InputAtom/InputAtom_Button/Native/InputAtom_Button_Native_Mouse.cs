using System;
using System.Collections;
using System.Collections.Generic;

using OpenTK.Input;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Button_Native_Mouse : InputAtom_Button_Native
    {
        private int device_index;
        private MouseButton button;

        public InputAtom_Button_Native_Mouse(int di, MouseButton b)
        {
            device_index = di;
            button = b;
        }

        public InputAtom_Button_Native_Mouse(MouseButton b) : this(-1, b) { }

        public override bool GetRawValue()
        {
            return MouseExtensions.GetState(device_index).IsButtonDown(button);
        }
    }
}