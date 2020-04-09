using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    
    public abstract class GamepadComponent
    {
        private GamepadComponentId id;

        private InputAtom atom;
        private InputAtomLockType lock_type;

        private bool has_frozen;

        protected abstract void FreezeInternal();
        protected abstract void UpdateInternal();

        protected T SwitchValues<T>(T value, T zero, T frozen)
        {
            if (atom.IsEffectivelyLocked())
            {
                switch (lock_type)
                {
                    case InputAtomLockType.Frozen: return frozen;
                    case InputAtomLockType.Zeroed: return zero;
                }

                throw new UnaccountedBranchException("lock_type", lock_type);
            }

            return value;
        }

        protected T SwitchSharedExclusive<T>(T value, T exclusive)
        {
            return SwitchValues<T>(value, exclusive, exclusive);
        }
        protected T SwitchSharedExclusive<T>(T value)
        {
            return SwitchSharedExclusive<T>(value, default(T));
        }

        protected T SwitchSharedFrozen<T>(T value, T frozen)
        {
            return SwitchValues<T>(value, default(T), frozen);
        }

        public GamepadComponent(string i, InputAtom a, InputAtomLockType l)
        {
            id = new GamepadComponentId(i);

            atom = a;
            lock_type = l;
        }

        public void Update()
        {
            UpdateInternal();

            if (atom.IsNominallyLocked())
            {
                if (has_frozen == false)
                {
                    FreezeInternal();
                    has_frozen = true;
                }
            }
            else
            {
                has_frozen = false;
            }
        }

        public void EnterLockSection(InputAtomLock @lock)
        {
            atom.EnterLockSection(@lock);
        }

        public void ExitLockSection(InputAtomLock @lock)
        {
            atom.ExitLockSection(@lock);
        }

        public GamepadComponentId GetId()
        {
            return id;
        }
    }
}