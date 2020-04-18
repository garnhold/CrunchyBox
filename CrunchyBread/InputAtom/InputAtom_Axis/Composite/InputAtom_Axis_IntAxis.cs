using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Axis_IntAxis : InputCompositeAtom, InputAtom_Axis
    {
        private InputAtom_IntAxis axis;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return axis;
        }

        public InputAtom_Axis_IntAxis(InputAtom_IntAxis a)
        {
            axis = a;
        }

        public float GetRawValue()
        {
            return axis.GetRawValue();
        }
    }
}