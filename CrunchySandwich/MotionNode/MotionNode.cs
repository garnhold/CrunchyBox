using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public class MotionNode : MonoBehaviourEX, MotionValueProvider
    {
        [SerializeFieldEX][PolymorphicField]private Signal signal;

        private ComponentCache_UpwardFromParent<MotionValueProvider> parent;

        private float motion_value;

        private void Start()
        {
            parent = new ComponentCache_UpwardFromParent<MotionValueProvider>(this);
        }

        private void Update()
        {
            motion_value = signal.Execute(parent.GetComponent().IfNotNull(p => p.GetMotionValue()));
        }

        public float GetMotionValue()
        {
            return motion_value;
        }
    }
}