using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_IntAxis_IntSliderPair : InputCompositeAtom, InputAtom_IntAxis
    {
        private InputAtom_IntSlider negative_slider;
        private InputAtom_IntSlider positive_slider;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return negative_slider;
            yield return positive_slider;
        }

        public InputAtom_IntAxis_IntSliderPair(InputAtom_IntSlider nb, InputAtom_IntSlider pb)
        {
            negative_slider = nb;
            positive_slider = pb;
        }

        public int GetRawValue()
        {
            return positive_slider.GetRawValue() - negative_slider.GetRawValue();
        }
    }
}