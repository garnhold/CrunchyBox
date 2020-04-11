using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Axis_Button : InputAtom_Axis
    {
        private InputAtom_Button button;
        private float value;

        public InputAtom_Axis_Button(InputAtom_Button b, float v)
        {
            button = b;
            value = v;
        }

        public InputAtom_Axis_Button(InputAtom_Button b) : this(b, 1.0f) { }

        public void EnterLockSection(InputAtomLock @lock)
        {
            button.EnterLockSection(@lock);
        }

        public void ExitLockSection(InputAtomLock @lock)
        {
            button.ExitLockSection(@lock);
        }

        public bool IsNominallyLocked()
        {
            return button.IsNominallyLocked();
        }

        public bool IsEffectivelyLocked()
        {
            return button.IsEffectivelyLocked();
        }

        public float GetRawValue()
        {
            return button.GetRawValue().ConvertBool(value);
        }
    }
}