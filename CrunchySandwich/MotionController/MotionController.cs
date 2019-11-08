using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class MotionController : MonoBehaviourEX
    {
        [SerializeFieldEX][PolymorphicField]private Signal signal;

        private ComponentCache_Upward<MotionValueProvider> motion_node;

        protected abstract void UpdateInternal(float value);

        private void Start()
        {
            motion_node = new ComponentCache_Upward<MotionValueProvider>(this);
        }

        private void Update()
        {
            float input = motion_node.GetComponent().GetMotionValue();

            if (signal != null)
                input = signal.Execute(input);
            
            UpdateInternal(input);
        }
    }
}