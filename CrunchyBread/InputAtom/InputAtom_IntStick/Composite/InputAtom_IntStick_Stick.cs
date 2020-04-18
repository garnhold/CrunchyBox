using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_IntStick_Stick : InputCompositeAtom, InputAtom_IntStick
    {
        private InputAtom_Stick stick;
        private float threshold;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return stick;
        }

        public InputAtom_IntStick_Stick(InputAtom_Stick s, float t = AxisSlider.Threshold)
        {
            stick = s;
            threshold = t;
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