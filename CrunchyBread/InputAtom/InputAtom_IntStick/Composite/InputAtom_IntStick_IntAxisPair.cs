using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_IntStick_IntAxisPair : InputAtom_IntStick
    {
        private InputAtom_IntAxis horizontal_axis;
        private InputAtom_IntAxis vertical_axis;

        public InputAtom_IntStick_IntAxisPair(InputAtom_IntAxis ha, InputAtom_IntAxis va)
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

        public VectorI2 GetRawValue()
        {
            return new VectorI2(
                horizontal_axis.GetRawValue(),
                vertical_axis.GetRawValue()
            );
        }
    }
}