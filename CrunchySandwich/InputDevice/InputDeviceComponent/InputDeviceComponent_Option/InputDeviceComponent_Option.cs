using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceComponent_Option<T> : InputDeviceComponent
    {
        private List<InputDeviceRawOption<T>> options;

        private T value;
        private T frozen_value;

        private InputDeviceEventLog<T> history;

        protected override void FreezeInternal()
        {
            frozen_value = value;
        }

        protected override void UpdateInternal()
        {
            value = options
                .FindFirst(o => o.IsSelected())
                .IfNotNull(o => o.GetValue(), value);

            history.LogValue(value);
        }

        public InputDeviceComponent_Option(IEnumerable<InputDeviceRawOption<T>> o)
        {
            options = o.ToList();

            history = new InputDeviceEventLog<T>(32);
        }
        public InputDeviceComponent_Option(params InputDeviceRawOption<T>[] o) : this((IEnumerable<InputDeviceRawOption<T>>)o) { }

        public T GetValue()
        {
            return SwitchSharedFrozen(value, frozen_value);
        }

        public InputDeviceEventHistory<T> GetHistory()
        {
            return SwitchSharedExclusive<InputDeviceEventHistory<T>>(
                history,
                InputDeviceEventEmptyHistory<T>.INSTANCE
            );
        }
    }
}