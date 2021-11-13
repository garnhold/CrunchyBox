using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    [Serializable]
    public class GameTimer : GameStopwatch, TemporalDuration
    {
        [SerializeField]private float duration;

        public GameTimer(float d, TimeType t) : base(t)
        {
            duration = d;
        }

        public GameTimer(float d) : this(d, TimeType.Active) { }

        public GameTimer(Duration d, TimeType t) : this(d.GetSeconds(), t) { }
        public GameTimer(Duration d) : this(d, TimeType.Active) { }

        public GameTimer() : this(1.0f) { }

        public void SetDurationInMilliseconds(long d)
        {
            duration = Duration.Milliseconds(d).GetSeconds();
        }

        public long GetDurationInMilliseconds()
        {
            return Duration.Seconds(duration).GetWholeMilliseconds();
        }
    }
}