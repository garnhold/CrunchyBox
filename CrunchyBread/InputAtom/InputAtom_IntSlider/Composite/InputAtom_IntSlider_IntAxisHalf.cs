using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_IntSlider_IntAxisHalf : InputCompositeAtom, InputAtom_IntSlider
    {
        private InputAtom_IntAxis axis;
        private bool is_positive;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return axis;
        }

        public InputAtom_IntSlider_IntAxisHalf(InputAtom_IntAxis a, bool p)
        {
            axis = a;
            is_positive = p;
        }

        public InputAtom_IntSlider_IntAxisHalf(InputAtom_IntAxis a) : this(a, true) { }

        public int GetRawValue()
        {
            if (is_positive)
                return axis.GetRawValue().BindBetween(0, 1);

            return -axis.GetRawValue().BindBetween(-1, 0);
        }
    }
}