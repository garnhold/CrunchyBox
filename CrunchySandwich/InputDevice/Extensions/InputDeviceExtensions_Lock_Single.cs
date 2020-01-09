using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class InputDeviceExtensions_Lock_Single
    {
        static public void EnterLockSection(this InputDeviceBase item, InputDeviceComponentId component, InputDeviceLock @lock)
        {
            item.GetComponent(component).EnterLockSection(@lock);
        }
        static public void ExitLockSection(this InputDeviceBase item, InputDeviceComponentId component, InputDeviceLock @lock)
        {
            item.GetComponent(component).ExitLockSection(@lock);
        }

        static public void ProcessLockSection(this InputDeviceBase item, InputDeviceComponentId component, InputDeviceLock @lock, Process process)
        {
            item.EnterLockSection(component, @lock);
                process();
            item.ExitLockSection(component, @lock);
        }
        static public T ProcessLockSection<T>(this InputDeviceBase item, InputDeviceComponentId component, InputDeviceLock @lock, Operation<T> operation)
        {
            T to_return = default(T);

            item.ProcessLockSection(component, @lock, delegate() {
                to_return = operation();
            });

            return to_return;
        }
    }
}