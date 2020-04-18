using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_IntAxis_IntStickHalf : InputCompositeAtom, InputAtom_IntAxis
    {
        private InputAtom_IntStick stick;
        private bool is_horizontal;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return stick;
        }

        public InputAtom_IntAxis_IntStickHalf(InputAtom_IntStick s, bool h)
        {
            stick = s;
            is_horizontal = h;
        }

        public InputAtom_IntAxis_IntStickHalf(InputAtom_IntStick s) : this(s, true) { }

        public int GetRawValue()
        {
            if (is_horizontal)
                return stick.GetRawValue().x;

            return stick.GetRawValue().y;
        }
    }
}