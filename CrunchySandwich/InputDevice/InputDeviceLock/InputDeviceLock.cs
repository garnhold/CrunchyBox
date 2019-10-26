using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class InputDeviceLock
    {
        private InputDeviceComponentState permission;

        private Frame touched_frame;

        public abstract void EnterLockSection(InputDeviceBase device);
        public abstract void ExitLockSection(InputDeviceBase device);

        public void Touch()
        {
            touched_frame = Frame.GetCurrentFrame();
        }

        public bool IsActive()
        {
            if (touched_frame.IsRecent())
                return true;

            return false;
        }

        public InputDeviceComponentState GetPermission()
        {
            return permission;
        }
    }
}