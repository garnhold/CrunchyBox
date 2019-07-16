using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [Serializable]
    public class InputDeviceComponentHandle
    {
        [SerializeField]private InputDeviceComponentId component;
        [SerializeField]private InputDeviceComponentState permission;

        private int idle_count;

        public bool Idle()
        {
            if (idle_count++ >= 3)
                return true;

            return false;
        }

        public void Touch()
        {
            idle_count = 0;
        }

        public void EnterHandleSection(InputDeviceBase device)
        {
            device.GetComponent(component).EnterHandleSection(this);
        }

        public void ExitHandleSection(InputDeviceBase device)
        {
            device.GetComponent(component).ExitHandleSection(this);
        }

        public InputDeviceComponentState GetPermission()
        {
            return permission;
        }
    }
}