using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputDeviceNativeAtom : InputAtom
    {
        private bool is_in_lock_section;
        private InputAtomLock current_lock;

        private void Touch()
        {
            if (current_lock != null)
            {
                if (current_lock.IsActive() == false)
                    current_lock = null;
            }
        }

        public void EnterLockSection(InputAtomLock @lock)
        {
            if (current_lock != null)
            {
                if (@lock == current_lock)
                    is_in_lock_section = true;
            }
            else
            {
                current_lock = @lock;
            }

            @lock.Touch();
        }

        public void ExitLockSection(InputAtomLock @lock)
        {
            if (current_lock == @lock)
                is_in_lock_section = false;
        }

        public bool IsNominallyLocked()
        {
            Touch();

            if (current_lock != null)
                return true;

            return false;
        }

        public bool IsEffectivelyLocked()
        {
            Touch();

            if (current_lock != null)
            {
                if (is_in_lock_section)
                    return false;

                return true;
            }

            return false;
        }
    }
}