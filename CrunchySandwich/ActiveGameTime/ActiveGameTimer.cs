using System;

using CrunchyDough;

namespace CrunchySandwich
{
    public class ActiveGameTimer : Timer
    {
        public ActiveGameTimer() : base(ActiveGameTime.INSTANCE) { }
    }
}