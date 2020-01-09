using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public abstract class InputDeviceRawStick
    {
        public abstract Vector2 GetValue();
    }
}