using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Axis_StickHalf : InputCompositeAtom, InputAtom_Axis
    {
        private InputAtom_Stick stick;
        private bool is_horizontal;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return stick;
        }

        public InputAtom_Axis_StickHalf(InputAtom_Stick s, bool h)
        {
            stick = s;
            is_horizontal = h;
        }

        public InputAtom_Axis_StickHalf(InputAtom_Stick s) : this(s, true) { }

        public float GetRawValue()
        {
            if (is_horizontal)
                return stick.GetRawValue().x;

            return stick.GetRawValue().y;
        }
    }
}