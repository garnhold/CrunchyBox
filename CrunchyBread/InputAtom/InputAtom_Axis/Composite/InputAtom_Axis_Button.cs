using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Axis_Button : InputCompositeAtom, InputAtom_Axis
    {
        private InputAtom_Button button;
        private float value;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return button;
        }

        public InputAtom_Axis_Button(InputAtom_Button b, float v)
        {
            button = b;
            value = v;
        }

        public InputAtom_Axis_Button(InputAtom_Button b) : this(b, 1.0f) { }

        public float GetRawValue()
        {
            return button.GetRawValue().ConvertBool(value);
        }
    }
}