using System;
using System.Text;

namespace Crunchy.Baker
{
    using Dough;
    
    public abstract class TimedTaskComparer
    {
        private int number_full_iterations;
        private int number_prewarm_iterations;
        
        private TimedTask timed_task_a;
        private TimedTask timed_task_b;

        protected abstract void RunIterationInternal();

        private void RunIteration(bool log_time)
        {
            RunIterationInternal();

            timed_task_a.Run(log_time);
            timed_task_b.Run(log_time);
        }

        public TimedTaskComparer(int f, int p, TimedTask a, TimedTask b)
        {
            number_full_iterations = f;
            number_prewarm_iterations = p;

            timed_task_a = a;
            timed_task_b = b;
        }

        public void Reset()
        {
            timed_task_a.Reset();
            timed_task_b.Reset();
        }

        public void Run()
        {
            for (int i = 0; i < number_prewarm_iterations; i++)
                RunIteration(false);

            for (int i = 0; i < number_full_iterations; i++)
                RunIteration(true);
        }

        public void CleanRun()
        {
            Reset();
            Run();
        }

        public string GetResultString()
        {
            StringBuilder string_builder = new StringBuilder();

            string_builder.Append("A(" + timed_task_a.GetResultString() + ")");
            string_builder.Append("B(" + timed_task_b.GetResultString() + ")");

            return string_builder.ToString();
        }

        public string CleanRunAndGetResultString()
        {
            CleanRun();
            return GetResultString();
        }
    }
}