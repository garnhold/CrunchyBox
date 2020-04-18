using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Button_AxisLimit : InputCompositeAtom, InputAtom_Button
    {
        private InputAtom_Axis axis;

        private bool is_positive;
        private float threshold;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return axis;
        }

        public InputAtom_Button_AxisLimit(InputAtom_Axis a, bool p, float t)
        {
            axis = a;

            is_positive = p;
            threshold = t;
        }

        public InputAtom_Button_AxisLimit(InputAtom_Axis a, bool p) : this(a, p, AxisSlider.Threshold) { }
        public InputAtom_Button_AxisLimit(InputAtom_Axis a) : this(a, true) { }

        public bool GetRawValue()
        {
            if (is_positive)
            {
                if (axis.GetRawValue() >= threshold)
                    return true;
            }
            else
            {
                if (axis.GetRawValue() <= -threshold)
                    return true;
            }

            return false;
        }
    }
}