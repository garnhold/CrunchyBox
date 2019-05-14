using System;

using CrunchyDough;

namespace CrunchyBaker
{
    public abstract class TimedTaskComparer_Simple : TimedTaskComparer
    {
        protected override void RunIterationInternal()
        {
        }

        public TimedTaskComparer_Simple(int f, int p, TimedTask a, TimedTask b) : base(f, p, a, b)
        {
        }
    }
}