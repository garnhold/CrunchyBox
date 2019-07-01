using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AddComponentMenu("Motion/Motion_PeriodicFunction")]
    public class Motion_PeriodicFunction : Motion
    {
        [SerializeField]private PeriodicFunction function;

        private float time_offset;
        private Motion parent_motion;

        private void Start()
        {
            time_offset = RandFloat.GetMagnitude(3600.0f);
            parent_motion = this.GetComponentUpwardFromParent<Motion>();
        }

        public override float GetMotionValue()
        {
            return function.Execute(
                parent_motion.IfNotNull(p => p.GetMotionValue(), () => Time.time + time_offset)
            );
        }
    }
}