﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public abstract class InputAtom_Axis_Native : InputDeviceNativeAtom, InputAtom_Axis
    {
        public abstract float GetValue();
    }
}