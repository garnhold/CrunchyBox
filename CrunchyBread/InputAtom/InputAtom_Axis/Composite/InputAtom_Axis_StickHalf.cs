using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Axis_StickHalf : InputAtom_Axis
    {
        private InputAtom_Stick stick;
        private bool is_horizontal;

        public InputAtom_Axis_StickHalf(InputAtom_Stick s, bool h)
        {
            stick = s;
            is_horizontal = h;
        }

        public InputAtom_Axis_StickHalf(InputAtom_Stick s) : this(s, true) { }

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

        public float GetValue()
        {
            if (is_horizontal)
                return stick.GetValue().x;

            return stick.GetValue().y;
        }
    }
}