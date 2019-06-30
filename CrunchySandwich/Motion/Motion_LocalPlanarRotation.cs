using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AddComponentMenu("Motion/Motion_LocalPlanarRotation")]
    public class Motion_LocalPlanarRotation : Motion
    {
        [SerializeField]private float center;
        [SerializeField]private float radius;

        protected override void UpdateInternal(float value)
        {
            this.SetLocalPlanarRotation(center + radius * value);
        }
    }
}