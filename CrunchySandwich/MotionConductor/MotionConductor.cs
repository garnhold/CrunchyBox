using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class MotionConductor : MonoBehaviourEX, MotionValueProvider
    {
        private Conductor conductor;
        private float motion_value;

        protected abstract IEnumerator<ConductorOrder> TheChoreography();

        private void Start()
        {
            conductor = new Conductor(TheChoreography);
        }

        private void Update()
        {
            conductor.Update();
        }

        public void SetMotionValue(float value)
        {
            motion_value = value;
        }

        public float GetMotionValue()
        {
            return motion_value;
        }
    }
}