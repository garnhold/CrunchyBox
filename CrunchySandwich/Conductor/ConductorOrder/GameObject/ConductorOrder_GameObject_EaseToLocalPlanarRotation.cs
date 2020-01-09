using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
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

        public override void Start()
        {
            start = GetTarget().GetPlanarRotation();
            easer.Start();
        }

        public override bool Fulfill()
        {
            GetTarget().SetPlanarRotation(
                start.GetInterpolateAngleInDegrees(end, easer.GetCurrentValue())
            );

            return easer.IsTimeOver();
        }
    }
}