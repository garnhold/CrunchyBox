using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public abstract class InputCompositeAtom : InputAtom
    {
        protected abstract IEnumerable<InputAtom> GetAtoms();

        public void EnterLockSection(InputAtomLock @lock)
        {
            GetAtoms().Process(a => a.EnterLockSection(@lock));
        }

        public void ExitLockSection(InputAtomLock @lock)
        {
            GetAtoms().Process(a => a.ExitLockSection(@lock));
        }

        public bool IsNominallyLocked()
        {
            if (GetAtoms().Has(a => a.IsNominallyLocked()))
                return true;

            return false;
        }

        public bool IsEffectivelyLocked()
        {
            if (GetAtoms().Has(a => a.IsEffectivelyLocked()))
                return true;

            return false;
        }
    }
}