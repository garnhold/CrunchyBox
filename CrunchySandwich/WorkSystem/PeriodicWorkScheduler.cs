using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class PeriodicWorkScheduler
    {
        private Timer_Duration timer;
        private WorkScheduler scheduler;

        public PeriodicWorkScheduler(long i, long a, Process p)
        {
            timer = new Timer_Duration(i).StartAndGet();

            scheduler = new WorkScheduler(a, delegate() {
                timer.Restart();

                p();
            });
        }

        public PeriodicWorkScheduler(Duration i, Duration a, Process p) : this(i.GetWholeMilliseconds(), a.GetWholeMilliseconds(), p) { }

        public void Update()
        {
            if (timer.IsTimeOver())
                scheduler.Schedule();
        }
    }
}