using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_IntAxis_Multiple : InputCompositeAtom, InputAtom_IntAxis
    {
        private List<InputAtom_IntAxis> axises;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            return axises.Convert<InputAtom_IntAxis, InputAtom>();
        }

        public InputAtom_IntAxis_Multiple(IEnumerable<InputAtom_IntAxis> b)
        {
            axises = b.ToList();
        }

        public InputAtom_IntAxis_Multiple(params InputAtom_IntAxis[] b) : this((IEnumerable<InputAtom_IntAxis>)b) { }

        public int GetRawValue()
        {
            return axises.Convert(a => a.GetRawValue()).Sum().BindOffset();
        }
    }
}