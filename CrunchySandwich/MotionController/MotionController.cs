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
        [SerializeFieldEX]private ComponentCache_Upward<MotionNode> motion_node;

        protected abstract void UpdateInternal(float value);

        private void Update()
        {
            float input = motion_node.GetComponent().GetMotionValue();

            if (signal != null)
                input = signal.Execute(input);
            
            UpdateInternal(input);
        }
    }
}