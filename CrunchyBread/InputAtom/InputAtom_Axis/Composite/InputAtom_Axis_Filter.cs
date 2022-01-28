using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Axis_Filter : InputCompositeAtom, InputAtom_Axis
    {
        private InputAtom_Axis axis;
        private AxisFilter filter;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return axis;
        }

        public InputAtom_Axis_Filter(InputAtom_Axis a, AxisFilter f)
        {
            axis = a;
            filter = f;
        }

        public float GetRawValue()
        {
            return filter.Filter(axis.GetRawValue());
        }
    }
}