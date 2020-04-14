using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class ConductorOrder_GameObject_EaseToLocalPlanarPosition : ConductorOrder_GameObject
    {
        private Vector2 start;
        private Vector2 end;

        private GameEaser easer;

        public ConductorOrder_GameObject_EaseToLocalPlanarPosition(GameObject t, Vector2 e, EaseOperation o, float d, TimeType tt) : base(t)
        {
            end = e;
            easer = new GameEaser(o, d, tt);
        }

        public override void InitializeFulfill()
        {
            start = GetTarget().GetLocalPlanarPosition();
        }

        public override void StartFulfill()
        {
            easer.Start();
        }

        public override void PauseFulfill()
        {
            easer.Pause();
        }

        public override bool UpdateFulfill()
        {
            GetTarget().SetLocalPlanarPosition(
                start.GetInterpolate(end, easer.GetCurrentValue())
            );

            return easer.IsTimeOver();
        }
    }
}