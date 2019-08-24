using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class GameAlarm_Range : GameAlarm
    {
        [SerializeField]private FloatRange range;

        protected override float CalculateInterval()
        {
            return RandFloat.GetBetween(range);
        }

        public GameAlarm_Range(FloatRange r, TimeType t) : base(t)
        {
            range = r;
        }

        public GameAlarm_Range(FloatRange r) : this(r, TimeType.Active) { }
        public GameAlarm_Range() : this(new FloatRange(0.0f, 1.0f)) { }
    }
}