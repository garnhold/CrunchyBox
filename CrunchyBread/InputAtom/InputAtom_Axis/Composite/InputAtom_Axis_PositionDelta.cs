using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Axis_PositionDelta : InputUpdateAtom, InputAtom_Axis
    {
        private InputAtom_Position position;

        private FloatDelta delta;

        protected override void StartAtomInternal()
        {
            delta.Clear();
        }

        protected override void UpdateAtomInternal()
        {
            delta.UpdateDelta(position.GetRawValue());
        }

        public InputAtom_Axis_PositionDelta(InputAtom_Position p)
        {
            position = p;

            delta = new FloatDelta();
        }

        public override void EnterLockSection(InputAtomLock @lock)
        {
            position.EnterLockSection(@lock);
        }

        public override void ExitLockSection(InputAtomLock @lock)
        {
            position.ExitLockSection(@lock);
        }

        public override bool IsNominallyLocked()
        {
            return position.IsNominallyLocked();
        }

        public override bool IsEffectivelyLocked()
        {
            return position.IsEffectivelyLocked();
        }

        public float GetRawValue()
        {
            return delta.GetDelta();
        }
    }
}