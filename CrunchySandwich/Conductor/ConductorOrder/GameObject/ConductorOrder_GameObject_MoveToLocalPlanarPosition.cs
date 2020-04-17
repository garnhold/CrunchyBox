using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class ConductorOrder_GameObject_MoveToLocalPlanarPosition : ConductorOrder_GameObject
    {
        private Vector2 end;

        private float speed;
        private TimeType time_type;

        protected override bool UpdateFulfill()
        {
            return GetTarget().MoveTowardsLocalPlanarPosition(end, speed * time_type.GetDelta());
        }

        public ConductorOrder_GameObject_MoveToLocalPlanarPosition(GameObject t, Vector2 e, float s, TimeType tt) : base(t)
        {
            end = e;

            speed = s;
            time_type = tt;
        }
    }
}