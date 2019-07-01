using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class Destroyer : TargetedMotion
    {
        protected override void InitializeInternal(GameObject target)
        {
            base.InitializeInternal(target);

            this.SetSpacarPosition(target.GetSpacarPosition());
        }

        private void Update()
        {
            if (IsDestroyed())
            {
                GetMotionTarget().Destroy();
                this.DestroyGameObject();
            }
        }

        public bool IsDestroyed()
        {
            if (GetMotionValue() >= 1.0f)
                return true;

            return false;
        }
    }
}