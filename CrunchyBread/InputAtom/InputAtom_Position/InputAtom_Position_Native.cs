using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public abstract class InputAtom_Position_Native : InputNativeAtom, InputAtom_Position
    {
        public abstract float GetRawValue();
    }
}