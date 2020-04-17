using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_IntStick_Stick : InputAtom_IntStick
    {
        private InputAtom_Stick stick;
        private float threshold;

        public InputAtom_IntStick_Stick(InputAtom_Stick s, float t = AxisSlider.Threshold)
        {
            stick = s;
            threshold = t;
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

        public VectorI2 GetRawValue()
        {
            VectorF2 vector = stick.GetRawValue();

            return new VectorI2(
                (vector.x > threshold).ConvertBool(1) + (vector.x < -threshold).ConvertBool(-1),
                (vector.y > threshold).ConvertBool(1) + (vector.y < -threshold).ConvertBool(-1)
            );
        }
    }
}