using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AddComponentMenu("Motion/Motion_LocalScale")]
    public class Motion_LocalScale : Motion
    {
        [SerializeField]private Vector3 center;
        [SerializeField]private Vector3 radius;

        protected override void UpdateInternal(float value)
        {
            this.SetLocalSpacarScale(center + radius * value);
        }
    }
}