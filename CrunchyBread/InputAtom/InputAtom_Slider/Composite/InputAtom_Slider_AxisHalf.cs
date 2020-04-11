using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Slider_AxisHalf : InputAtom_Slider
    {
        private InputAtom_Axis axis;
        private bool is_positive;

        public InputAtom_Slider_AxisHalf(InputAtom_Axis a, bool p)
        {
            axis = a;
            is_positive = p;
        }

        public InputAtom_Slider_AxisHalf(InputAtom_Axis a) : this(a, true) { }

        public void EnterLockSection(InputAtomLock @lock)
        {
            axis.EnterLockSection(@lock);
        }

        public void ExitLockSection(InputAtomLock @lock)
        {
            axis.ExitLockSection(@lock);
        }

        public bool IsNominallyLocked()
        {
            return axis.IsNominallyLocked();
        }

        public bool IsEffectivelyLocked()
        {
            return axis.IsEffectivelyLocked();
        }

        public float GetRawValue()
        {
            if (is_positive)
                return axis.GetRawValue().BindBetween(0.0f, 1.0f);

            return -axis.GetRawValue().BindBetween(-1.0f, 0.0f);
        }
    }
}