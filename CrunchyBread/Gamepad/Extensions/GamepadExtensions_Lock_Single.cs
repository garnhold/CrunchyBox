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
            item.EnterLockSection(component, @lock);
                process();
            item.ExitLockSection(component, @lock);
        }
        static public T ProcessLockSection<T>(this GamepadBase item, GamepadComponentId component, InputAtomLock @lock, Operation<T> operation)
        {
            T to_return = default(T);

            item.ProcessLockSection(component, @lock, delegate() {
                to_return = operation();
            });

            return to_return;
        }
    }
}