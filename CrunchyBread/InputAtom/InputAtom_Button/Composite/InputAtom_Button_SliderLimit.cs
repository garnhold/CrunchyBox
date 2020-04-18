using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Button_SliderLimit : InputCompositeAtom, InputAtom_Button
    {
        private InputAtom_Slider slider;

        private float threshold;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return slider;
        }

        public InputAtom_Button_SliderLimit(InputAtom_Slider a, float t)
        {
            slider = a;

            threshold = t;
        }

        public InputAtom_Button_SliderLimit(InputAtom_Slider a) : this(a, AxisSlider.Threshold) { }

        public bool GetRawValue()
        {
            if (slider.GetRawValue() >= threshold)
                return true;

            return false;
        }
    }
}