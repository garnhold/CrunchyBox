using System;

using CrunchyDough;

namespace CrunchySandwich
{
    public class GameTimer : Timer
    {
        public GameTimer() : base(TimeSource_GameTime.INSTANCE) { }
    }
}