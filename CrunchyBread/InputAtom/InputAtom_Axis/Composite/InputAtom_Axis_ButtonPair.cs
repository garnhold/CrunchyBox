using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Axis_ButtonPair : InputCompositeAtom, InputAtom_Axis
    {
        private InputAtom_Button negative_button;
        private InputAtom_Button positive_button;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return negative_button;
            yield return positive_button;
        }

        public InputAtom_Axis_ButtonPair(InputAtom_Button nb, InputAtom_Button pb)
        {
            negative_button = nb;
            positive_button = pb;
        }

        public float GetRawValue()
        {
            return negative_button.GetRawValue().ConvertBool(-1.0f) + positive_button.GetRawValue().ConvertBool(1.0f);
        }
    }
}