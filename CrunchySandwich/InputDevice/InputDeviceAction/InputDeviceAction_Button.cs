using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public abstract class InputDeviceAction_Button : InputDeviceAction
    {
        [SerializeField]private InputDeviceButtonId button;

        protected abstract bool IsOccuringThisFrameInternal(InputDeviceComponent_Button button);

        public override bool IsOccuringThisFrame(InputDeviceBase device)
        {
            if (IsOccuringThisFrameInternal(device.GetButton(button)))
                return true;

            return false;
        }

        public override IEnumerable<InputDeviceComponentId> GetComponentIds()
        {
            yield return button;
        }
    }
}