using System;

namespace Crunchy.Baker
{
    using Dough;
    
    public class TimedTask_RepeatingProcess : TimedTask
    {
        private Process process;
        private int number_iterations;

        protected override void RunInternal()
        {
            for (int i = 0; i < number_iterations; i++)
                process();
        }

        public TimedTask_RepeatingProcess(Process p, int i)
        {
            process = p;
            number_iterations = i;
        }
    }
}