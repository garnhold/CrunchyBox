using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class InputDeviceRawOption<T>
    {
        public abstract T GetValue();
        public abstract bool IsSelected();
    }
}