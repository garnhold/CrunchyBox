using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_IntSlider_Button : InputCompositeAtom, InputAtom_IntSlider
    {
        private InputAtom_Button button;
        private int value;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return button;
        }

        public InputAtom_IntSlider_Button(InputAtom_Button b, int v)
        {
            button = b;
            value = v;
        }

        public InputAtom_IntSlider_Button(InputAtom_Button b) : this(b, 1) { }

        public int GetRawValue()
        {
            return button.GetRawValue().ConvertBool(value);
        }
    }
}