using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceComponent_Option<T> : InputDeviceComponent
    {
        private InputDeviceRawOption<T> option;
        private List<InputDeviceRawOption<T>> options;

        protected override void FreezeInternal()
        {
        }

        protected override void UpdateInternal()
        {
            option = options.FindFirst(o => o.IsSelected()) ?? option;
        }

        public InputDeviceComponent_Option(IEnumerable<InputDeviceRawOption<T>> o)
        {
            options = o.ToList();
        }
        public InputDeviceComponent_Option(params InputDeviceRawOption<T>[] o) : this((IEnumerable<InputDeviceRawOption<T>>)o) { }

        public T GetValue()
        {
            return option.IfNotNull(o => o.GetValue());
        }
    }
}