using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class MotionNode_Motion_RootRandom : MotionNode_Motion
    {
        [SerializeField]private GameStopwatch timer;

        protected override float GetMotionValueInput()
        {
            return timer.GetElapsedTimeInSeconds();
        }

        private void Start()
        {
            timer.StartWithRandomElapsedTimeInSeconds(3600.0f);
        }
    }
}