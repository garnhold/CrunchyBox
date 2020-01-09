using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class InputDeviceLockStateExtensions
    {
        static public bool IsUnlocked(this InputDeviceLockState item)
        {
            if (item == InputDeviceLockState.None)
                return true;

            return false;
        }

        static public bool IsLocked(this InputDeviceLockState item)
        {
            if (item.IsUnlocked() == false)
                return true;

            return false;
        }

        static public T ConvertState<T>(this InputDeviceLockState item, T value, T zero, T frozen)
        {
            switch (item)
            {
                case InputDeviceLockState.None: return value;
                case InputDeviceLockState.Zeroed: return zero;
                case InputDeviceLockState.Frozen: return frozen;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}