using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class ConductorOrder_GameObject_EaseToPlanarPosition : ConductorOrder_GameObject
    {
        private Vector2 start;
        private Vector2 end;

        private GameEaser easer;

        protected override bool InitializeFulfill()
        {
            start = GetTarget().GetPlanarPosition();
            return true;
        }

        protected override void StartFulfill()
        {
            easer.Start();
        }

        protected override void PauseFulfill()
        {
            easer.Pause();
        }

        protected override bool UpdateFulfill()
        {
            GetTarget().SetPlanarPosition(
                start.GetInterpolate(end, easer.GetCurrentValue())
            );

            return easer.IsTimeOver();
        }

        public ConductorOrder_GameObject_EaseToPlanarPosition(GameObject t, Vector2 e, EaseOperation o, float d, TimeType tt) : base(t)
        {
            end = e;
            easer = new GameEaser(o, d, tt);
        }
    }
}