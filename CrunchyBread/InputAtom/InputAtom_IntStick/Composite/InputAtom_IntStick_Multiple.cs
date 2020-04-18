using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_IntStick_Multiple : InputCompositeAtom, InputAtom_IntStick
    {
        private List<InputAtom_IntStick> sticks;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            return sticks.Convert<InputAtom_IntStick, InputAtom>();
        }

        public InputAtom_IntStick_Multiple(IEnumerable<InputAtom_IntStick> b)
        {
            sticks = b.ToList();
        }

        public InputAtom_IntStick_Multiple(params InputAtom_IntStick[] b) : this((IEnumerable<InputAtom_IntStick>)b) { }

        public VectorI2 GetRawValue()
        {
            return sticks.Convert(a => a.GetRawValue()).Sum().BindBetween(-VectorI2.ONE, VectorI2.ONE);
        }
    }
}