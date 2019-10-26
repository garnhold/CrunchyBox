using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class InputDeviceLockExtensions_IEnumerable
    {
        static public void EnterLockSection(this IEnumerable<InputDeviceLock> item, InputDeviceBase device)
        {
            item.Process(i => i.EnterLockSection(device));
        }
        static public void ExitLockSection(this IEnumerable<InputDeviceLock> item, InputDeviceBase device)
        {
            item.Process(i => i.ExitLockSection(device));
        }
    }
}