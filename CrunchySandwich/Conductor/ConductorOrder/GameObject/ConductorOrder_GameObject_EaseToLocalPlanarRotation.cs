using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class ConductorOrder_GameObject_EaseToLocalPlanarRotation : ConductorOrder_GameObject
    {
        private float start;
        private float end;

        private GameEaser easer;

        protected override bool InitializeFulfill()
        {
            start = GetTarget().GetPlanarRotation();
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
            GetTarget().SetPlanarRotation(
                start.GetInterpolateAngleInDegrees(end, easer.GetCurrentValue())
            );

            return easer.IsTimeOver();
        }

        public ConductorOrder_GameObject_EaseToLocalPlanarRotation(GameObject t, float e, EaseOperation o, float d, TimeType tt) : base(t)
        {
            end = e;
            easer = new GameEaser(o, d, tt);
        }
    }
}