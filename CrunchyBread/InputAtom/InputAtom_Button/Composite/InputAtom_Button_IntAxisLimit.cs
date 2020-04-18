using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Button_IntAxisLimit : InputCompositeAtom, InputAtom_Button
    {
        private InputAtom_IntAxis axis;

        private bool is_positive;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            yield return axis;
        }

        public InputAtom_Button_IntAxisLimit(InputAtom_IntAxis a, bool p)
        {
            axis = a;

            is_positive = p;
        }

        public InputAtom_Button_IntAxisLimit(InputAtom_IntAxis a) : this(a, true) { }

        public bool GetRawValue()
        {
            if (is_positive)
            {
                if (axis.GetRawValue() >= 1)
                    return true;
            }
            else
            {
                if (axis.GetRawValue() <= -1)
                    return true;
            }

            return false;
        }
    }
}