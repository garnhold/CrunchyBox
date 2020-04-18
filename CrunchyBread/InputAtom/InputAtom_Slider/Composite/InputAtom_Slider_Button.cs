using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Slider_Button : InputCompositeAtom, InputAtom_Slider
    {
        private InputAtom_Button button;
        private float value;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return button;
        }

        public InputAtom_Slider_Button(InputAtom_Button b, float v)
        {
            button = b;
            value = v;
        }

        public InputAtom_Slider_Button(InputAtom_Button b) : this(b, 1.0f) { }

        public float GetRawValue()
        {
            return button.GetRawValue().ConvertBool(value);
        }
    }
}