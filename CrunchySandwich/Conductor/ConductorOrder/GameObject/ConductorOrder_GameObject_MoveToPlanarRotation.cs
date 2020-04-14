using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class ConductorOrder_GameObject_MoveToPlanarRotation : ConductorOrder_GameObject
    {
        private float end;

        private float speed;
        private TimeType time_type;

        public ConductorOrder_GameObject_MoveToPlanarRotation(GameObject t, float e, float s, TimeType tt) : base(t)
        {
            end = e;

            speed = s;
            time_type = tt;
        }

        public override bool UpdateFulfill()
        {
            return GetTarget().MoveTowardsPlanarRotation(end, speed * time_type.GetDelta());
        }
    }
}