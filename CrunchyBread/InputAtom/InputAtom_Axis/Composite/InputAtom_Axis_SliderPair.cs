using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Axis_SliderPair : InputAtom_Axis
    {
        private InputAtom_Slider negative_slider;
        private InputAtom_Slider positive_slider;

        public InputAtom_Axis_SliderPair(InputAtom_Slider nb, InputAtom_Slider pb)
        {
            negative_slider = nb;
            positive_slider = pb;
        }

        public void EnterLockSection(InputAtomLock @lock)
        {
            negative_slider.EnterLockSection(@lock);
            positive_slider.EnterLockSection(@lock);
        }

        public void ExitLockSection(InputAtomLock @lock)
        {
            positive_slider.ExitLockSection(@lock);
            negative_slider.ExitLockSection(@lock);
        }

        public bool IsNominallyLocked()
        {
            return negative_slider.IsNominallyLocked() | positive_slider.IsNominallyLocked();
        }

        public bool IsEffectivelyLocked()
        {
            return negative_slider.IsEffectivelyLocked() | positive_slider.IsEffectivelyLocked();
        }

        public float GetValue()
        {
            return positive_slider.GetValue() - negative_slider.GetValue();
        }
    }
}