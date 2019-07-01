using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class Destroyer_Duration : Destroyer
    {
        [SerializeField]private float duration;

        private GameTimer timer;

        protected override void InitializeInternal(GameObject target)
        {
            base.InitializeInternal(target);

            timer = new GameTimer().StartAndGet();
        }

        protected override float GetMotionValueInternal()
        {
            return timer.GetElapsedTimeInSeconds() / duration;
        }
    }
}