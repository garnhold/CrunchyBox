using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class Scheduler
    {
        private Stopwatch timer;
        private ISchedule schedule;

        private Timer target_timer;

        public Scheduler(ISchedule s)
        {
            timer = new Stopwatch().StartAndGet();
            schedule = s;

            target_timer = new Timer();
        }

        public void Update(long lookahead, long target_milliseconds)
        {
            target_timer.RestartSetDurationInMilliseconds(target_milliseconds);

            schedule.Complete(timer.GetElapsedTimeInMilliseconds());
            schedule.Lookahead(timer.GetElapsedTimeInMilliseconds() + lookahead, target_timer.GetTimeTillInMilliseconds());
        }

        public void ScheduleAt(long timestamp, Process process)
        {
            schedule.ScheduleProcess(timestamp, process);
        }
        public void ScheduleIn(long delay, Process process)
        {
            ScheduleAt(timer.GetElapsedTimeInMilliseconds() + delay, process);
        }
    }
}