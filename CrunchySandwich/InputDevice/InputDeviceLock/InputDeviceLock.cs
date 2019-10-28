using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class InputDeviceLock
    {
        private Frame touched_frame;

        public abstract InputDeviceLockState GetLockState(InputDeviceComponent component);

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
    }
}