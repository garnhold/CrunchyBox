using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public abstract class InputUpdateAtom<T> : InputAtom<T>
    {
        private FrameProcess frame_process;

        protected virtual void StartAtomInternal() { }
        protected abstract void UpdateAtomInternal();

        protected abstract T GetRawValueInternal();

        public abstract bool IsNominallyLocked();
        public abstract bool IsEffectivelyLocked();

        public abstract void EnterLockSection(InputAtomLock @lock);
        public abstract void ExitLockSection(InputAtomLock @lock);

        public InputUpdateAtom()
        {
            frame_process = new FrameProcess(() => StartAtomInternal(), () => UpdateAtomInternal());
        }

        public T GetRawValue()
        {
            frame_process.Touch();

            return GetRawValueInternal();
        }
    }
}