using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Button_AxisLimit : InputAtom_Button
    {
        private InputAtom_Axis axis;

        private bool is_positive;
        private float threshold;

        public InputAtom_Button_AxisLimit(InputAtom_Axis a, bool p, float t)
        {
            axis = a;

            is_positive = p;
            threshold = t;
        }

        public InputAtom_Button_AxisLimit(InputAtom_Axis a, bool p) : this(a, p, 0.85f) { }
        public InputAtom_Button_AxisLimit(InputAtom_Axis a) : this(a, true) { }

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

        public bool GetValue()
        {
            if (is_positive)
            {
                if (axis.GetValue() >= threshold)
                    return true;
            }
            else
            {
                if (axis.GetValue() <= -threshold)
                    return true;
            }

            return false;
        }
    }
}