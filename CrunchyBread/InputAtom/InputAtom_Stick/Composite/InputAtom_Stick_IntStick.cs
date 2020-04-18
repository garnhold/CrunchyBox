using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Stick_IntStick : InputCompositeAtom, InputAtom_Stick
    {
        private InputAtom_IntStick stick;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return stick;
        }

        public InputAtom_Stick_IntStick(InputAtom_IntStick s)
        {
            stick = s;
        }

        public VectorF2 GetRawValue()
        {
            return stick.GetRawValue();
        }
    }
}