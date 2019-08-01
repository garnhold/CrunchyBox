using System;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class ActiveGameTimer_Duration : Timer_Duration
    {
        public ActiveGameTimer_Duration(Duration i) : base(i.GetWholeMilliseconds(), ActiveGameTime.INSTANCE) { }
        public ActiveGameTimer_Duration(float s) : this(Duration.Seconds(s)) { }
        public ActiveGameTimer_Duration() : this(0.0f) { }
    }
}