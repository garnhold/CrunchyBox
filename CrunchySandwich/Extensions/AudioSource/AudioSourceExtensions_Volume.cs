using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class AudioSourceExtensions_Volume
    {
        static public void AdjustVolume(this AudioSource item, float amount)
        {
            item.volume = (item.volume + amount).BindPercent();
        }
        static public void InterpolateVolume(this AudioSource item, float target, float amount)
        {
            item.volume = item.volume.GetInterpolate(target, amount).BindPercent();
        }
    }
}