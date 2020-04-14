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

        public ConductorOrder_GameObject_EaseToLocalPlanarRotation(GameObject t, float e, EaseOperation o, float d, TimeType tt) : base(t)
        {
            end = e;
            easer = new GameEaser(o, d, tt);
        }

        public override void InitializeFulfill()
        {
            start = GetTarget().GetPlanarRotation();
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
            GetTarget().SetPlanarRotation(
                start.GetInterpolateAngleInDegrees(end, easer.GetCurrentValue())
            );

            return easer.IsTimeOver();
        }
    }
}