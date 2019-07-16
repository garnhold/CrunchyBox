using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class InputDeviceComponentStateExtensions
    {
        static public bool IsShared(this InputDeviceComponentState item)
        {
            if (item == InputDeviceComponentState.Shared)
                return true;

            return false;
        }

        static public bool IsExclusive(this InputDeviceComponentState item)
        {
            if (item.IsShared() == false)
                return true;

            return false;
        }

        static public T ConvertState<T>(this InputDeviceComponentState item, T value, T zero, T frozen)
        {
            switch (item)
            {
                case InputDeviceComponentState.Shared: return value;
                case InputDeviceComponentState.Zeroed: return zero;
                case InputDeviceComponentState.Frozen: return frozen;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}