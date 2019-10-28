using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class InputDeviceAction_Stick : InputDeviceAction
    {
        [SerializeField]private InputDeviceStickId stick;

        protected abstract bool IsOccuringThisFrameInternal(InputDeviceComponent_Stick stick);

        public override bool IsOccuringThisFrame(InputDeviceBase device)
        {
            if (IsOccuringThisFrameInternal(device.GetStick(stick)))
                return true;

            return false;
        }

        public override IEnumerable<InputDeviceComponentId> GetComponentIds()
        {
            yield return stick;
        }
    }
}