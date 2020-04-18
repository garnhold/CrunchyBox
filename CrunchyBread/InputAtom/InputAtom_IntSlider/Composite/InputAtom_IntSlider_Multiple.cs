using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_IntSlider_Multiple : InputCompositeAtom, InputAtom_IntSlider
    {
        private List<InputAtom_IntSlider> sliders;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            return sliders.Convert<InputAtom_IntSlider, InputAtom>();
        }

        public InputAtom_IntSlider_Multiple(IEnumerable<InputAtom_IntSlider> s)
        {
            sliders = s.ToList();
        }

        public InputAtom_IntSlider_Multiple(params InputAtom_IntSlider[] b) : this((IEnumerable<InputAtom_IntSlider>)b) { }

        public int GetRawValue()
        {
            return sliders.Convert(a => a.GetRawValue()).Sum().BindPercent();
        }
    }
}