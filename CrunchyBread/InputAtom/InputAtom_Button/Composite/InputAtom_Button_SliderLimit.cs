using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Button_SliderLimit : InputAtom_Button
    {
        private InputAtom_Slider slider;

        private float threshold;

        public InputAtom_Button_SliderLimit(InputAtom_Slider a, float t)
        {
            slider = a;

            threshold = t;
        }

        public InputAtom_Button_SliderLimit(InputAtom_Slider a) : this(a, AxisSlider.Threshold) { }

        public void EnterLockSection(InputAtomLock @lock)
        {
            slider.EnterLockSection(@lock);
        }

        public void ExitLockSection(InputAtomLock @lock)
        {
            slider.ExitLockSection(@lock);
        }

        public bool IsNominallyLocked()
        {
            return slider.IsNominallyLocked();
        }

        public bool IsEffectivelyLocked()
        {
            return slider.IsEffectivelyLocked();
        }

        public bool GetRawValue()
        {
            if (slider.GetRawValue() >= threshold)
                return true;

            return false;
        }
    }
}