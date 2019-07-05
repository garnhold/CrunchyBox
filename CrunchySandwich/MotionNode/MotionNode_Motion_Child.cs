using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class MotionNode_Motion_Child : MotionNode_Motion
    {
        private MotionNode parent_motion_node;

        protected override float GetMotionValueInput()
        {
            return parent_motion_node.GetMotionValue();
        }

        private void Start()
        {
            parent_motion_node = this.GetComponentUpwardFromParent<MotionNode>();
        }
    }
}