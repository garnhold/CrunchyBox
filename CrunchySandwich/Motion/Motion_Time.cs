using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AddComponentMenu("Motion/Motion_Time")]
    public class Motion_Time : Motion
    {
        [SerializeField]private float time_offset;

        public override float GetMotionValue()
        {
            return Time.time + time_offset;
        }
    }
}