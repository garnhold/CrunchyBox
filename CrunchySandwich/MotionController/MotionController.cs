using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public abstract class MotionController : MonoBehaviourEX
    {
        [SerializeFieldEX][PolymorphicField]private List<Signal> signals;

        private ComponentCache_Upward<MotionValueProvider> motion_node;

        protected abstract void UpdateInternal(float value);

        private void Start()
        {
            motion_node = new ComponentCache_Upward<MotionValueProvider>(this);
        }

        private void Update()
        {
            UpdateInternal(signals.Execute(
                motion_node.Use(n => n.GetMotionValue())
            ));
        }
    }
}