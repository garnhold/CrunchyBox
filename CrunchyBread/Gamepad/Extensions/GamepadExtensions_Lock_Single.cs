using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    
    static public class GamepadExtensions_Lock_Single
    {
        static public void EnterLockSection(this GamepadBase item, GamepadComponentId component, InputAtomLock @lock)
        {
            item.GetComponent(component).EnterLockSection(@lock);
        }
        static public void ExitLockSection(this GamepadBase item, GamepadComponentId component, InputAtomLock @lock)
        {
            item.GetComponent(component).ExitLockSection(@lock);
        }

        static public void ProcessLockSection(this GamepadBase item, GamepadComponentId component, InputAtomLock @lock, Process process)
        {
            item.GetComponent(component).ProcessLockSection(@lock, process);
        }
        static public T ProcessLockSection<T>(this GamepadBase item, GamepadComponentId component, InputAtomLock @lock, Operation<T> operation)
        {
            return item.GetComponent(component).ProcessLockSection<T>(@lock, operation);
        }
    }
}