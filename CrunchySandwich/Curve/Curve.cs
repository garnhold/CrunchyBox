using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    [Serializable]
    public class Curve
    {
        [SerializeField]private List<float> percents;

        public float GetValue(float x)
        {
            if (x <= 0.0f)
                return percents.GetFirst();

            if (x >= 1.0f)
                return percents.GetLast();

            return percents.GetInterpolate(percents.GetFinalIndex() * x);
        }

        public float GetLoopedValue(float x)
        {
            return GetValue(x.GetLooped(1.0f));
        }
    }
}