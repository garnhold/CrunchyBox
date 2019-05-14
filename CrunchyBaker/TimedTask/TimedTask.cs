using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBaker
{
    public abstract class TimedTask
    {
        private LogTimer log_timer;

        protected abstract void RunInternal();

        public TimedTask()
        {
            log_timer = new LogTimer();
        }

        public void Reset()
        {
            log_timer.Clear();
        }

        public void Run(bool log_time)
        {
            log_timer.TimeProcess(delegate() {
                RunInternal();
            }, log_time);
        }

        public IEnumerable<long> GetTimesInMilliseconds()
        {
            return log_timer.GetTimesInMilliseconds();
        }

        public string GetResultString()
        {
            StringBuilder string_builder = new StringBuilder();

            string_builder.Append("Total: " + GetTimesInMilliseconds().Sum() + "ms ");
            string_builder.Append("Avg: " + GetTimesInMilliseconds().Average() + "ms ");

            return string_builder.ToString();
        }
    }
}