using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    
    static public class GamepadComponentExtensions_Lock
    {
        static public void ProcessLockSection(this GamepadComponent item, InputAtomLock @lock, Process process)
        {
            item.EnterLockSection(@lock);
                process();
            item.ExitLockSection(@lock);
        }
        static public T ProcessLockSection<T>(this GamepadComponent item, InputAtomLock @lock, Operation<T> operation)
        {
            T to_return = default(T);

            item.ProcessLockSection(@lock, delegate () {
                to_return = operation();
            });

            return to_return;
        }
    }
}