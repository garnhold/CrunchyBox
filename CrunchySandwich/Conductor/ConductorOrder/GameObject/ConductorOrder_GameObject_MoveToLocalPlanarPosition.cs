using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class ConductorOrder_GameObject_MoveToLocalPlanarPosition : ConductorOrder_GameObject
    {
        private Vector2 end;

        private float speed;
        private TimeType time_type;

        public ConductorOrder_GameObject_MoveToLocalPlanarPosition(GameObject t, Vector2 e, float s, TimeType tt) : base(t)
        {
            end = e;

            speed = s;
            time_type = tt;
        }

        public override bool Fulfill()
        {
            return GetTarget().MoveTowardsLocalPlanarPosition(end, speed * time_type.GetDelta());
        }
    }
}