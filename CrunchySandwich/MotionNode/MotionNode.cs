using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class MotionNode : MonoBehaviour
    {
        private Motion motion;

        protected abstract void UpdateInternal(float value);

        private void Start()
        {
            motion = this.GetComponentUpward<Motion>();
        }

        private void Update()
        {
            UpdateInternal(motion.GetMotionValue());
        }
    }
}