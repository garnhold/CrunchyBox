using System;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class GameTimer_Duration : Timer_Duration
    {
        public GameTimer_Duration(float s) : base((long)Duration.Seconds(s).GetMilliseconds(), TimeSource_GameTime.INSTANCE) { }
        public GameTimer_Duration() : this(0.0f) { }
    }
}