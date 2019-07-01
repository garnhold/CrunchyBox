using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AddComponentMenu("Motion/Motion_Manual")]
    public class Motion_Manual : Motion
    {
        [SerializeField]private float value;

        public void SetMotionValue(float v)
        {
            value = v;
        }

        public override float GetMotionValue()
        {
            return value;
        }
    }
}