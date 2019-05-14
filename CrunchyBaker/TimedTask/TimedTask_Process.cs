using System;

using CrunchyDough;

namespace CrunchyBaker
{
    public class TimedTask_Process : TimedTask
    {
        private Process process;

        protected override void RunInternal()
        {
            process();
        }

        public TimedTask_Process(Process p)
        {
            process = p;
        }
    }
}