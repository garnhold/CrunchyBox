using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public abstract class InputUpdateAtom : InputAtom
    {
        private Frame frame;

        protected virtual void StartAtomInternal() { }
        protected abstract void UpdateAtomInternal();

        public abstract bool IsNominallyLocked();
        public abstract bool IsEffectivelyLocked();

        public abstract void EnterLockSection(InputAtomLock @lock);
        public abstract void ExitLockSection(InputAtomLock @lock);

        protected void Touch()
        {
            if (frame.IsNotCurrent())
            {
                if (frame.IsNotRecent())
                    StartAtomInternal();

                UpdateAtomInternal();
                frame = Frame.GetCurrentFrame();
            }
        }
    }
}