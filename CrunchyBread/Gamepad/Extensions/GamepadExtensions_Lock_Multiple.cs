using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    
    static public class GamepadExtensions_Lock_Multiple
    {
        static public void EnterLockSection(this GamepadBase item, IEnumerable<GamepadComponentId> components, InputAtomLock @lock)
        {
            components.Process(i => item.GetComponent(i).EnterLockSection(@lock));
        }
        static public void ExitLockSection(this GamepadBase item, IEnumerable<GamepadComponentId> components, InputAtomLock @lock)
        {
            components.Process(i => item.GetComponent(i).ExitLockSection(@lock));
        }

        static public void ProcessLockSection(this GamepadBase item, IEnumerable<GamepadComponentId> components, InputAtomLock @lock, Process process)
        {
            item.EnterLockSection(components, @lock);
                process();
            item.ExitLockSection(components, @lock);
        }
        static public T ProcessLockSection<T>(this GamepadBase item, IEnumerable<GamepadComponentId> components, InputAtomLock @lock, Operation<T> operation)
        {
            T to_return = default(T);

            item.ProcessLockSection(components, @lock, delegate() {
                to_return = operation();
            });

            return to_return;
        }
    }
}