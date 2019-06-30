using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AddComponentMenu("Motion/Motion_LocalPlanarScale")]
    public class Motion_LocalPlanarScale : Motion
    {
        [SerializeField]private Vector2 center;
        [SerializeField]private Vector2 radius;

        protected override void UpdateInternal(float value)
        {
            this.SetLocalPlanarScale(center + radius * value);
        }
    }
}