﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class LogTimer
    {
        private Timer timer;
        private List<long> times_in_milliseconds;

        public LogTimer(TimeSource t)
        {
            timer = new Timer(t);
            times_in_milliseconds = new List<long>();
        }

        public LogTimer() : this(TimeSource_Stopwatch.INSTANCE) { }

        public void Clear()
        {
            timer.StopClear();
            times_in_milliseconds.Clear();
        }

        public bool Start()
        {
            return timer.Start();
        }

        public bool Stop(bool log_time)
        {
            if (timer.Pause())
            {
                if (log_time)
                    times_in_milliseconds.Add(timer.GetElapsedTimeInMilliseconds());

                timer.StopClear();
                return true;
            }

            return false;
        }

        public bool TimeProcess(Process process, bool log_time)
        {
            if (Start())
            {
                process();
                Stop(log_time);

                return true;
            }

            return false;
        }

        public IEnumerable<long> GetTimesInMilliseconds()
        {
            return times_in_milliseconds;
        }
    }
}