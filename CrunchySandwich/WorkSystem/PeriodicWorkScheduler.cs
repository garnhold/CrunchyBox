using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public class PeriodicWorkScheduler
    {
        private Stopwatch timer;
        private Operation<long> operation;

        private WorkScheduler scheduler;

        public PeriodicWorkScheduler(UnityEngine.Object r, Operation<long> w, Process p)
        {
            timer = new Stopwatch().StartAndGet();
            operation = w;

            scheduler = new WorkScheduler(r, p);
        }

        public PeriodicWorkScheduler(UnityEngine.Object r, Operation<Duration> w, Process p) : this(r, () => w().GetWholeMilliseconds(), p) { }

        public void Update()
        {
            if (Application.isPlaying)
            {
                long work_interval = operation();

                if (timer.GetElapsedTimeInMilliseconds() >= work_interval)
                {
                    scheduler.Request(work_interval);

                    timer.Restart();
                }
            }
            else
            {
                Execute();
            }
        }

        public void Execute()
        {
            scheduler.Execute();
        }
    }
}