using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public abstract class InputAtom_IntStick_Native : InputNativeAtom, InputAtom_IntStick
    {
        public abstract VectorI2 GetRawValue();
    }
}