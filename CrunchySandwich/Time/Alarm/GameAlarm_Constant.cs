using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class GameAlarm_Constant : GameAlarm
    {
        [SerializeField]private float constant;

        protected override float CalculateInterval()
        {
            return constant;
        }

        public GameAlarm_Constant(float c, TimeType t) : base(t)
        {
            constant = c;
        }

        public GameAlarm_Constant(float c) : this(c, TimeType.Active) { }
        public GameAlarm_Constant() : this(1.0f) { }
    }
}