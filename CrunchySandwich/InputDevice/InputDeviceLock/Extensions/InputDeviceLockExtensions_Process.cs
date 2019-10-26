using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class InputDeviceLockExtensions_Process
    {
        static public void ProcessLock(this InputDeviceLock item, InputDeviceBase device, Process process)
        {
            item.EnterLockSection(device);
                process();
            item.ExitLockSection(device);
        }
        static public T ProcessLock<T>(this InputDeviceLock item, InputDeviceBase device, Operation<T> operation)
        {
            T to_return = default(T);

            item.ProcessLock(device, delegate() {
                to_return = operation();
            });

            return to_return;
        }
    }
}