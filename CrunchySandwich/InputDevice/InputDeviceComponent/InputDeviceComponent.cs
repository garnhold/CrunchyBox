using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public abstract class InputDeviceComponent
    {
        private bool is_in_lock_section;
        private InputDeviceLock current_lock;

        protected abstract void FreezeInternal();
        protected abstract void UpdateInternal();

        protected T SwitchValues<T>(T value, T zero, T frozen)
        {
            return GetInternalState().ConvertState(value, zero, frozen);
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

        private InputDeviceLockState GetInternalState()
        {
            if (current_lock != null)
            {
                if (is_in_lock_section)
                    return InputDeviceLockState.None;

                return current_lock.GetLockState(this);
            }

            return InputDeviceLockState.None;
        }

        public void Update()
        {
            if (current_lock != null)
            {
                if (current_lock.IsActive() == false)
                    current_lock = null;
            }

            UpdateInternal();
        }

        public void EnterLockSection(InputDeviceLock @lock)
        {
            if (current_lock != null)
            {
                if (@lock == current_lock)
                    is_in_lock_section = true;
            }
            else
            {
                InputDeviceLockState lock_state = @lock.GetLockState(this);

                if (lock_state.IsLocked())
                {
                    current_lock = @lock;

                    if (lock_state == InputDeviceLockState.Frozen)
                        FreezeInternal();
                }
            }

            @lock.Touch();
        }

        public void ExitLockSection(InputDeviceLock @lock)
        {
            if (current_lock == @lock)
                is_in_lock_section = false;
        }
    }
}