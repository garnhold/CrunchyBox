using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Axis_Multiple : InputCompositeAtom, InputAtom_Axis
    {
        private List<InputAtom_Axis> axises;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            return axises.Convert<InputAtom_Axis, InputAtom>();
        }

        public InputAtom_Axis_Multiple(IEnumerable<InputAtom_Axis> a)
        {
            axises = a.ToList();
        }

        public InputAtom_Axis_Multiple(params InputAtom_Axis[] a) : this((IEnumerable<InputAtom_Axis>)a) { }

        public float GetRawValue()
        {
            return axises.Convert(a => a.GetRawValue()).Sum().BindOffset();
        }
    }
}