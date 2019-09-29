using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class MotionNode : MonoBehaviourEX
    {
        [SerializeFieldEX][PolymorphicField]private Signal signal;

        private ComponentCache_Upward<MotionNode> parent;

        private float motion_value;

        private void Start()
        {
            parent = new ComponentCache_Upward<MotionNode>(this);
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