using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Axis_ButtonPair : InputAtom_Axis
    {
        private InputAtom_Button negative_button;
        private InputAtom_Button positive_button;

        public InputAtom_Axis_ButtonPair(InputAtom_Button nb, InputAtom_Button pb)
        {
            negative_button = nb;
            positive_button = pb;
        }

        public void EnterLockSection(InputAtomLock @lock)
        {
            negative_button.EnterLockSection(@lock);
            positive_button.EnterLockSection(@lock);
        }

        public void ExitLockSection(InputAtomLock @lock)
        {
            positive_button.ExitLockSection(@lock);
            negative_button.ExitLockSection(@lock);
        }

        public bool IsNominallyLocked()
        {
            return negative_button.IsNominallyLocked() | positive_button.IsNominallyLocked();
        }

        public bool IsEffectivelyLocked()
        {
            return negative_button.IsEffectivelyLocked() | positive_button.IsEffectivelyLocked();
        }

        public float GetRawValue()
        {
            return negative_button.GetRawValue().ConvertBool(-1.0f) + positive_button.GetRawValue().ConvertBool(1.0f);
        }
    }
}