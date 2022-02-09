using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    [AddComponentMenu("Motion/MotionController_Destroy")]
    public class MotionController_Destroy : MotionController
    {
        [SerializeField] private GameObject target;
        [SerializeField] private float destroy_threshold;

        protected override void UpdateInternal(float value)
        {
            if (value >= destroy_threshold)
                GetTarget().Destroy();
        }

        public GameObject GetTarget()
        {
            return target.Coalesce(gameObject);
        }
    }
}