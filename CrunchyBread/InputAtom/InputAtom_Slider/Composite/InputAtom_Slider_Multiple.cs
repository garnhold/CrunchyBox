using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Slider_Multiple : InputCompositeAtom, InputAtom_Slider
    {
        private List<InputAtom_Slider> sliders;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            return sliders.Convert<InputAtom_Slider, InputAtom>();
        }

        public InputAtom_Slider_Multiple(IEnumerable<InputAtom_Slider> b)
        {
            sliders = b.ToList();
        }

        public InputAtom_Slider_Multiple(params InputAtom_Slider[] b) : this((IEnumerable<InputAtom_Slider>)b) { }

        public float GetRawValue()
        {
            return sliders.Convert(a => a.GetRawValue()).Sum().BindPercent();
        }
    }
}