using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Button_Multiple : InputCompositeAtom, InputAtom_Button
    {
        private List<InputAtom_Button> buttons;

        protected override IEnumerable<InputAtom> GetAtoms()
        {
            return buttons.Convert<InputAtom_Button, InputAtom>();
        }

        public InputAtom_Button_Multiple(IEnumerable<InputAtom_Button> b)
        {
            buttons = b.ToList();
        }

        public InputAtom_Button_Multiple(params InputAtom_Button[] b) : this((IEnumerable<InputAtom_Button>)b) { }

        public bool GetRawValue()
        {
            return buttons.Has(b => b.GetRawValue());
        }
    }
}