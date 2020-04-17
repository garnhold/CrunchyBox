using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Stick_IntStick : InputAtom_Stick
    {
        private InputAtom_IntStick stick;

        public InputAtom_Stick_IntStick(InputAtom_IntStick s)
        {
            stick = s;
        }

        public void EnterLockSection(InputAtomLock @lock)
        {
            stick.EnterLockSection(@lock);
        }

        public void ExitLockSection(InputAtomLock @lock)
        {
            stick.ExitLockSection(@lock);
        }

        public bool IsNominallyLocked()
        {
            return stick.IsNominallyLocked();
        }

        public bool IsEffectivelyLocked()
        {
            return stick.IsEffectivelyLocked();
        }

        public VectorF2 GetRawValue()
        {
            return stick.GetRawValue();
        }
    }
}