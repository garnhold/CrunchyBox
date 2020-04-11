using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public abstract class InputAtom_Stick_Native : InputNativeAtom, InputAtom_Stick
    {
        public abstract VectorF2 GetRawValue();
    }
}