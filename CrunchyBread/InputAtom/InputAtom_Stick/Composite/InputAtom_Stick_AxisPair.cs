using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Stick_AxisPair : InputCompositeAtom, InputAtom_Stick
    {
        private InputAtom_Axis horizontal_axis;
        private InputAtom_Axis vertical_axis;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return horizontal_axis;
            yield return vertical_axis;
        }

        public InputAtom_Stick_AxisPair(InputAtom_Axis ha, InputAtom_Axis va)
        {
            horizontal_axis = ha;
            vertical_axis = va;
        }

        public VectorF2 GetRawValue()
        {
            return new VectorF2(
                horizontal_axis.GetRawValue(),
                vertical_axis.GetRawValue()
            );
        }
    }
}