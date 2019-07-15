using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [Serializable]
    public abstract class InputDeviceActionIndicator
    {
        public abstract GameObject SpawnIndicator();
    }
}