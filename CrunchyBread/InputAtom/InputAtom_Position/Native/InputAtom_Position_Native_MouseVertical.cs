using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Position_Native_MouseVertical : InputAtom_Position_Native
    {
        private int device_index;

        public InputAtom_Position_Native_MouseVertical(int di)
        {
            device_index = di;
        }

        public InputAtom_Position_Native_MouseVertical() : this(-1) { }

        public override float GetValue()
        {
            return MouseExtensions.GetState(device_index).Y;
        }
    }
}