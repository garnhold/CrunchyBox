﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public abstract class InputAtom_Position_Native : InputDeviceNativeAtom, InputAtom_Position
    {
        public abstract float GetValue();
    }
}