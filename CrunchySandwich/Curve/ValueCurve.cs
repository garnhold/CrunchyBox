using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [Serializable]
    public class ValueCurve
    {
        [SerializeField]private Curve curve;

        [SerializeField]private float domain_start;
        [SerializeField]private float domain_end;

        [SerializeField]private float range_start;
        [SerializeField]private float range_end;

        public float GetDomainStart()
        {
            return domain_start;
        }

        public float GetDomainEnd()
        {
            return domain_end;
        }

        public float GetRangeStart()
        {
            return range_start;
        }

        public float GetRangeEnd()
        {
            return range_end;
        }

        public float GetValue(float x)
        {
            return curve.GetValue(x.ConvertFromRangeToPercent(domain_start, domain_end))
                .ConvertFromPercentToRange(range_start, range_end);
        }
    }
}