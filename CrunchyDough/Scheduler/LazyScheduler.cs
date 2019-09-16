using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class LazyScheduler
    {
        private Stopwatch frame_timer;
        private Scheduler scheduler;

        public LazyScheduler(ISchedule s)
        {
            frame_timer = new Stopwatch();
            scheduler = new Scheduler(s);
        }

        public void Update(long target_frame_milliseconds, long lookahead)
        {
            scheduler.Update(lookahead, target_frame_milliseconds - frame_timer.GetElapsedTimeInMilliseconds());

            frame_timer.Restart();
        }

        public void ScheduleAt(long timestamp, Process process)
        {
            scheduler.ScheduleAt(timestamp, process);
        }

        public void ScheduleIn(long delay, Process process)
        {
            scheduler.ScheduleIn(delay, process);
        }
    }
}