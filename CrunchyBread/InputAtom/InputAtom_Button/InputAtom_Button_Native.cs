using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public abstract class InputAtom_Button_Native : InputNativeAtom, InputAtom_Button
    {
        public abstract bool GetRawValue();
    }
}