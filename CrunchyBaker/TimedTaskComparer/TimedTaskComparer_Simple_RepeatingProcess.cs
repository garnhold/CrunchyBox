using System;

using CrunchyDough;

namespace CrunchyBaker
{
    public class TimedTaskComparer_Simple_RepeatingProcess : TimedTaskComparer_Simple
    {
        public TimedTaskComparer_Simple_RepeatingProcess(int f, int p, Process a, Process b, int i)
            : base(f, p, new TimedTask_RepeatingProcess(a, i), new TimedTask_RepeatingProcess(b, i))
        {
        }
    }
}