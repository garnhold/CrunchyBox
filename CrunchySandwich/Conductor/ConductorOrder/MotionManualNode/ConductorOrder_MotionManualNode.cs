using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public abstract class ConductorOrder_MotionManualNode : ConductorOrder
    {
        private MotionManualNode node;

        protected void SetMotionValue(float value)
        {
            node.SetMotionValue(value);
        }

        protected void ForceMotionValue(float value)
        {
            node.ForceMotionValue(value);
        }

        protected float GetMotionValue()
        {
            return node.GetMotionValue();
        }

        public ConductorOrder_MotionManualNode(MotionManualNode n)
        {
            node = n;
        }
    }
}