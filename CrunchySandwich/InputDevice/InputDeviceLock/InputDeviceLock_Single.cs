using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceLock_Single : InputDeviceLock
    {
        private InputDeviceComponentId component;

        public override void EnterLockSection(InputDeviceBase device)
        {
            device.GetComponent(component).EnterLockSection(this);
        }

        public override void ExitLockSection(InputDeviceBase device)
        {
            device.GetComponent(component).ExitLockSection(this);
        }
    }
}