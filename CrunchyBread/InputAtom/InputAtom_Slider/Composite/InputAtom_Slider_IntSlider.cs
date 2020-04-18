using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Slider_IntSlider : InputCompositeAtom, InputAtom_Slider
    {
        private InputAtom_IntSlider slider;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return slider;
        }

        public InputAtom_Slider_IntSlider(InputAtom_IntSlider s)
        {
            slider = s;
        }

        public float GetRawValue()
        {
            return slider.GetRawValue();
        }
    }
}