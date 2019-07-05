using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class MotionController : MonoBehaviour
    {
        [SerializeField]private Motion motion;

        private MotionNode motion_node;

        protected abstract void UpdateInternal(float value);

        private void Start()
        {
            motion_node = this.GetComponentUpward<MotionNode>();
        }

        private void Update()
        {
            float input = motion_node.GetMotionValue();

            if (motion != null)
                input = motion.Execute(input);
            
            UpdateInternal(input);
        }
    }
}