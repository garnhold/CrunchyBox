using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Axis_SliderPair : InputCompositeAtom, InputAtom_Axis
    {
        private InputAtom_Slider negative_slider;
        private InputAtom_Slider positive_slider;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return negative_slider;
            yield return positive_slider;
        }

        public InputAtom_Axis_SliderPair(InputAtom_Slider nb, InputAtom_Slider pb)
        {
            negative_slider = nb;
            positive_slider = pb;
        }

        public float GetRawValue()
        {
            return positive_slider.GetRawValue() - negative_slider.GetRawValue();
        }
    }
}