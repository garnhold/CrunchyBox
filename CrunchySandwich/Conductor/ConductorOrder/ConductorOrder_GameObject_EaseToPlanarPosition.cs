using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class ConductorOrder_GameObject_EaseToPlanarPosition : ConductorOrder_GameObject
    {
        private Vector2 start;
        private Vector2 end;

        private GameEaser easer;

        public ConductorOrder_GameObject_EaseToPlanarPosition(GameObject t, Vector2 e, EaseOperation o, float d, TimeType tt) : base(t)
        {
            start = t.GetPlanarPosition();
            end = e;

            easer = new GameEaser(o, d, tt).StartAndGet();
        }

        public override bool Fulfill()
        {
            GetTarget().SetPlanarPosition(
                start.GetInterpolate(end, easer.GetCurrentValue())
            );

            return easer.IsTimeOver();
        }
    }
}