using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class TargetedMotion : MonoBehaviour
    {
        private GameObject target;

        protected virtual void InitializeInternal(GameObject target) { }
        protected abstract float GetMotionValueInternal();

        public void Initialize(GameObject t)
        {
            target = t;

            InitializeInternal(target);
        }

        public GameObject GetMotionTarget()
        {
            return target;
        }

        public float GetMotionValue()
        {
            return GetMotionValueInternal();
        }
    }
}