using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AddComponentMenu("Motion/Motion_EaseFunction")]
    public class Motion_EaseFunction : Motion
    {
        [SerializeField]private EaseFunction function;

        private float start_time;
        private Motion parent_node;

        private void Start()
        {
            start_time = Time.time;
            parent_node = this.GetComponentUpwardFromParent<Motion>();
        }

        public override float GetMotionValue()
        {
            return function.Execute(
                parent_node.IfNotNull(p => p.GetMotionValue(), () => Time.time - start_time)
            );
        }
    }
}