using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Stick_Multiple : InputCompositeAtom, InputAtom_Stick
    {
        private List<InputAtom_Stick> sticks;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            return sticks.Convert<InputAtom_Stick, InputAtom>();
        }

        public InputAtom_Stick_Multiple(IEnumerable<InputAtom_Stick> b)
        {
            sticks = b.ToList();
        }

        public InputAtom_Stick_Multiple(params InputAtom_Stick[] b) : this((IEnumerable<InputAtom_Stick>)b) { }

        public VectorF2 GetRawValue()
        {
            return sticks.Convert(a => a.GetRawValue()).Sum().BindMagnitudeBelow(1.0f);
        }
    }
}