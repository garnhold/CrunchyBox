using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class Motion : MonoBehaviour
    {
        private MotionNode motion_node;

        protected abstract void UpdateInternal(float input);

        private void Start()
        {
            motion_node = this.GetComponentUpwardFromParent<MotionNode>();
        }

        private void Update()
        {
            UpdateInternal(motion_node.GetValue());
        }
    }
}