using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class TargetedMotionNode : MonoBehaviour
    {
        private TargetedMotion motion;

        protected virtual void StartInternal(GameObject target) { }
        protected abstract void UpdateInternal(GameObject target, float value);

        private void Start()
        {
            motion = this.GetComponentUpward<TargetedMotion>();

            StartInternal(motion.GetMotionTarget());
        }

        private void Update()
        {
            UpdateInternal(motion.GetMotionTarget(), motion.GetMotionValue());
        }
    }
}