using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Slider_AxisHalf : InputCompositeAtom, InputAtom_Slider
    {
        private InputAtom_Axis axis;
        private bool is_positive;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return axis;
        }

        public InputAtom_Slider_AxisHalf(InputAtom_Axis a, bool p)
        {
            axis = a;
            is_positive = p;
        }

        public InputAtom_Slider_AxisHalf(InputAtom_Axis a) : this(a, true) { }

        public float GetRawValue()
        {
            if (is_positive)
                return axis.GetRawValue().BindBetween(0.0f, 1.0f);

            return -axis.GetRawValue().BindBetween(-1.0f, 0.0f);
        }
    }
}