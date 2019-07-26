using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class InputDeviceActionIndicator
    {
        public abstract GameObject SpawnIndicator(InputDeviceAction action);
    }

    public abstract class InputDeviceActionIndicator<T> : InputDeviceActionIndicator where T : InputDeviceAction
    {
        protected abstract GameObject SpawnIndicatorInternal(T action);

        public override GameObject SpawnIndicator(InputDeviceAction action)
        {
            T cast;

            if (action.Convert<T>(out cast))
                return SpawnIndicatorInternal(cast);

            return null;
        }
    }
}