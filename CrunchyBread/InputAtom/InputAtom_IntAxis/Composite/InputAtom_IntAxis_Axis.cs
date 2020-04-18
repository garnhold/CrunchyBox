using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_IntAxis_Axis : InputCompositeAtom, InputAtom_IntAxis
    {
        private InputAtom_Axis axis;
        private float threshold;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return axis;
        }

        public InputAtom_IntAxis_Axis(InputAtom_Axis a, float t)
        {
            axis = a;
            threshold = t;
        }

        public InputAtom_IntAxis_Axis(InputAtom_Axis a) : this(a, AxisSlider.Threshold) { }

        public int GetRawValue()
        {
            if (axis.GetRawValue() >= threshold)
                return 1;

            if (axis.GetRawValue() <= -threshold)
                return -1;

            return 0;
        }
    }
}