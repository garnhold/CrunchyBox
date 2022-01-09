using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class MotionNode : MonoBehaviourEX, MotionValueProvider
    {
        [SerializeFieldEX]private List<Signal> signals;

        private ComponentCache_UpwardFromParent<MotionValueProvider> parent;

        private float motion_value;

        private void Start()
        {
            parent = new ComponentCache_UpwardFromParent<MotionValueProvider>(this);
        }

        private void Update()
        {
            motion_value = signals.Execute(parent.Use(p => p.GetMotionValue()));
        }

        public float GetMotionValue()
        {
            return motion_value;
        }
    }
}