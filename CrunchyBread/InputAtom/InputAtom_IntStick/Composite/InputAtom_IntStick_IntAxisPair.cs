using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_IntStick_IntAxisPair : InputCompositeAtom, InputAtom_IntStick
    {
        private InputAtom_IntAxis horizontal_axis;
        private InputAtom_IntAxis vertical_axis;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return horizontal_axis;
            yield return vertical_axis;
        }

        public InputAtom_IntStick_IntAxisPair(InputAtom_IntAxis ha, InputAtom_IntAxis va)
        {
            horizontal_axis = ha;
            vertical_axis = va;
        }

        public VectorI2 GetRawValue()
        {
            return new VectorI2(
                horizontal_axis.GetRawValue(),
                vertical_axis.GetRawValue()
            );
        }
    }
}