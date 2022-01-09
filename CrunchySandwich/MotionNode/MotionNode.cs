using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class MotionNode : MonoBehaviourEX, MotionValueProvider
    {
        [SerializeFieldEX]private SignalChain signal_chain;

        private ComponentCache_UpwardFromParent<MotionValueProvider> parent;

        private float motion_value;

        private void Start()
        {
            parent = new ComponentCache_UpwardFromParent<MotionValueProvider>(this);
        }

        private void Update()
        {
            motion_value = signal_chain.Execute(parent.GetComponent().IfNotNull(p => p.GetMotionValue()));
        }

        public float GetMotionValue()
        {
            return motion_value;
        }
    }
}