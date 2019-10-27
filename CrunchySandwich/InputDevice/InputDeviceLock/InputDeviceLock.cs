using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceLock
    {
        private InputDeviceComponentState permission;

        private Frame touched_frame;

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