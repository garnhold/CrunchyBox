using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    [AddComponentMenu("Motion/MotionController_FollowPosition")]
    public class MotionController_FollowPosition : MotionController
    {
        [SerializeField]private float speed;
        [SerializeField]private TimeType time_type;

        [SerializeField]private List<GameObject> targets;

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            targets.Process(t => GizmosExtensions.DrawPoint(t.GetSpacarPosition()));
        }

        protected override void UpdateInternal(float value)
        {
            targets.GetPercentCapped(value.ConvertFromOffsetToPercent())
                .IfNotNull(t => this.InterpolateSpacarPosition(
                    t.GetSpacarPosition(), 
                    speed * time_type.GetDelta()
                ));
        }
    }
}