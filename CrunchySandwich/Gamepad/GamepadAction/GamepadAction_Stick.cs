using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    public abstract class GamepadAction_Stick : GamepadAction
    {
        [SerializeFieldEX]private GamepadStickId stick;

        protected abstract bool IsOccuringThisFrameInternal(GamepadComponent_Stick stick);

        public override bool IsOccuringThisFrame(GamepadBase device)
        {
            if (IsOccuringThisFrameInternal(device.GetStick(stick)))
                return true;

            return false;
        }

        public override IEnumerable<GamepadComponentId> GetComponentIds()
        {
            yield return stick;
        }
    }
}