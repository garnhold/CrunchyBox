using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class InputDeviceBase
    {
        public abstract void Update();

        public abstract InputDeviceComponent GetComponent(InputDeviceComponentId component);
        public abstract InputDeviceComponent_Axis GetAxis(InputDeviceAxisId axis);
        public abstract InputDeviceComponent_Button GetButton(InputDeviceButtonId button);
        public abstract InputDeviceComponent_Stick GetStick(InputDeviceStickId stick);
    }
}