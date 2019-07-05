using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class MotionNode_Motion : MotionNode
    {
        [SerializeField]private Motion motion;

        protected abstract float GetMotionValueInput();

        public override float GetMotionValue()
        {
            float input = GetMotionValueInput();

            if(motion != null)
                return motion.Execute(input);

            return input;
        }
    }
}