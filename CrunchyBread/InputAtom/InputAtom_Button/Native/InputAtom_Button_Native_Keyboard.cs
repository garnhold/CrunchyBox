using System;
using System.Collections;
using System.Collections.Generic;

using OpenTK.Input;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Button_Native_Keyboard : InputAtom_Button_Native
    {
        private int device_index;
        private Key key;

        public InputAtom_Button_Native_Keyboard(int di, Key k)
        {
            device_index = di;
            key = k;
        }

        public InputAtom_Button_Native_Keyboard(Key k) : this(-1, k) { }

        public override bool GetValue()
        {
            return KeyboardExtensions.GetState(device_index).IsKeyDown(key);
        }
    }
}