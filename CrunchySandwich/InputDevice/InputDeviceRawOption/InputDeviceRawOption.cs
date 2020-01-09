using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public abstract class InputDeviceRawOption<T>
    {
        public abstract T GetValue();
        public abstract bool IsSelected();
    }
}