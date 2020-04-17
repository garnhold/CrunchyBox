using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_IntAxis_Axis : InputAtom_IntAxis
    {
        private InputAtom_Axis axis;
        private float threshold;

        public InputAtom_IntAxis_Axis(InputAtom_Axis a, float t)
        {
            axis = a;
            threshold = t;
        }

        public InputAtom_IntAxis_Axis(InputAtom_Axis a) : this(a, AxisSlider.Threshold) { }

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

        public int GetRawValue()
        {
            if (axis.GetRawValue() >= threshold)
                return 1;

            if (axis.GetRawValue() <= -threshold)
                return -1;

            return 0;
        }
    }
}