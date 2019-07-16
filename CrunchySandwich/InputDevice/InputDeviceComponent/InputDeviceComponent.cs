using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class InputDeviceComponent
    {
        private bool is_in_exclusive_handle_section;
        private InputDeviceComponentHandle exclusive_handle;

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

        private InputDeviceComponentState GetInternalState()
        {
            if (exclusive_handle != null)
            {
                if (is_in_exclusive_handle_section)
                    return InputDeviceComponentState.Shared;

                return exclusive_handle.GetPermission();
            }

            return InputDeviceComponentState.Shared;
        }

        public void Update()
        {
            if (exclusive_handle != null)
            {
                if (exclusive_handle.Idle())
                    exclusive_handle = null;
            }

            UpdateInternal();
        }

        public void EnterHandleSection(InputDeviceComponentHandle handle)
        {
            if (exclusive_handle != null)
            {
                if (handle == exclusive_handle)
                    is_in_exclusive_handle_section = true;
            }
            else
            {
                if (handle.GetPermission().IsExclusive())
                {
                    exclusive_handle = handle;

                    if (exclusive_handle.GetPermission() == InputDeviceComponentState.Frozen)
                        FreezeInternal();
                }
            }

            handle.Touch();
        }

        public void ExitHandleSection(InputDeviceComponentHandle handle)
        {
            if (exclusive_handle == handle)
                is_in_exclusive_handle_section = false;
        }
    }
}