using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Stick_AxisPair : InputAtom_Stick
    {
        private InputAtom_Axis horizontal_axis;
        private InputAtom_Axis vertical_axis;

        public InputAtom_Stick_AxisPair(InputAtom_Axis ha, InputAtom_Axis va)
        {
            horizontal_axis = ha;
            vertical_axis = va;
        }

        public void EnterLockSection(InputAtomLock @lock)
        {
            horizontal_axis.EnterLockSection(@lock);
            vertical_axis.EnterLockSection(@lock);
        }

        public void ExitLockSection(InputAtomLock @lock)
        {
            vertical_axis.ExitLockSection(@lock);
            horizontal_axis.ExitLockSection(@lock);
        }

        public bool IsNominallyLocked()
        {
            return horizontal_axis.IsNominallyLocked() | vertical_axis.IsNominallyLocked();
        }

        public bool IsEffectivelyLocked()
        {
            return horizontal_axis.IsEffectivelyLocked() | vertical_axis.IsEffectivelyLocked();
        }

        public VectorF2 GetValue()
        {
            return new VectorF2(
                horizontal_axis.GetValue(),
                vertical_axis.GetValue()
            );
        }
    }
}