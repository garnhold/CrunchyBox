using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class InputDeviceExtensions_Lock_Multiple
    {
        static public void EnterLockSection(this InputDeviceBase item, IEnumerable<InputDeviceComponentId> components, InputDeviceLock @lock)
        {
            components.Process(i => item.GetComponent(i).EnterLockSection(@lock));
        }
        static public void ExitLockSection(this InputDeviceBase item, IEnumerable<InputDeviceComponentId> components, InputDeviceLock @lock)
        {
            components.Process(i => item.GetComponent(i).ExitLockSection(@lock));
        }

        static public void ProcessLockSection(this InputDeviceBase item, IEnumerable<InputDeviceComponentId> components, InputDeviceLock @lock, Process process)
        {
            item.EnterLockSection(components, @lock);
                process();
            item.ExitLockSection(components, @lock);
        }
        static public T ProcessLockSection<T>(this InputDeviceBase item, IEnumerable<InputDeviceComponentId> components, InputDeviceLock @lock, Operation<T> operation)
        {
            T to_return = default(T);

            item.ProcessLockSection(components, @lock, delegate() {
                to_return = operation();
            });

            return to_return;
        }
    }
}