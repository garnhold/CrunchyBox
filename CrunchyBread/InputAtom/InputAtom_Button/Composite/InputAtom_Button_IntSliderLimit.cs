using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Button_IntSliderLimit : InputCompositeAtom, InputAtom_Button
    {
        private InputAtom_IntSlider slider;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return slider;
        }

        public InputAtom_Button_IntSliderLimit(InputAtom_IntSlider a)
        {
            slider = a;
        }

        public bool GetRawValue()
        {
            if (slider.GetRawValue() >= 1)
                return true;

            return false;
        }
    }
}