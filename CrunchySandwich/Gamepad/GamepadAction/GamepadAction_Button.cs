using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    public abstract class GamepadAction_Button : GamepadAction
    {
        [SerializeField]private GamepadButtonId button;

        protected abstract bool IsOccuringThisFrameInternal(GamepadComponent_Button button);

        public override bool IsOccuringThisFrame(GamepadBase gamepad)
        {
            if (IsOccuringThisFrameInternal(gamepad.GetButton(button)))
                return true;

            return false;
        }

        public override IEnumerable<GamepadComponentId> GetComponentIds()
        {
            yield return button;
        }
    }
}