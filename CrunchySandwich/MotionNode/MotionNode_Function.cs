using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AddComponentMenu("Motion/MotionNode_Function")]
    public class MotionNode_Function : MotionNode
    {
        [SerializeField]private PeriodicFunction function;

        private float time_offset;
        private MotionNode parent_motion_node;

        private void Start()
        {
            time_offset = RandFloat.GetMagnitude(3600.0f);
            parent_motion_node = this.GetComponentUpwardFromParent<MotionNode>();
        }

        public override float GetValue()
        {
            return function.Execute(
                parent_motion_node.IfNotNull(p => p.GetValue(), () => Time.time + time_offset)
            );
        }
    }
}