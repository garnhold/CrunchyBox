using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Axis_PositionDelta : InputUpdateAtom<float>, InputAtom_Axis
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

        protected override float GetRawValueInternal()
        {
            return delta.GetDelta();
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
    }
}