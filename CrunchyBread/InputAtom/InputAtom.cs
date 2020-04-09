using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public interface InputAtom
    {
        void EnterLockSection(InputAtomLock @lock);
        void ExitLockSection(InputAtomLock @lock);

        bool IsNominallyLocked();
        bool IsEffectivelyLocked();
    }

    public interface InputAtom<T> : InputAtom
    {
        T GetValue();
    }
}