using System;
using System.Reflection;

namespace CrunchyDough
{
    public class FluxTimer : Timer
    {
        private TimeSource_Flux flux;

        public FluxTimer(TimeSource t) : base(new TimeSource_Flux(t))
        {
            flux = (TimeSource_Flux)GetTimeSource();
        }

        public FluxTimer() : this(TimeSource_Stopwatch.INSTANCE) { }

        public void SetMultiplier(float m)
        {
            flux.SetMultiplier(m);
        }

        public float GetMultiplier()
        {
            return flux.GetMultiplier();
        }
    }
}