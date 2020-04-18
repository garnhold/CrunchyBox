using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_IntAxis_ButtonPair : InputCompositeAtom, InputAtom_IntAxis
    {
        private InputAtom_Button negative_button;
        private InputAtom_Button positive_button;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return negative_button;
            yield return positive_button;
        }

        public InputAtom_IntAxis_ButtonPair(InputAtom_Button nb, InputAtom_Button pb)
        {
            negative_button = nb;
            positive_button = pb;
        }

        public int GetRawValue()
        {
            return negative_button.GetRawValue().ConvertBool(-1) + positive_button.GetRawValue().ConvertBool(1);
        }
    }
}