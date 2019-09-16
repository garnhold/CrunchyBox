using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class PeriodicWorkScheduler
    {
        private Timer timer;
        private WorkScheduler scheduler;

        public PeriodicWorkScheduler(long i, Process p)
        {
            timer = new Timer(i).StartAndGet();
            scheduler = new WorkScheduler(i, p);
        }

        public PeriodicWorkScheduler(Duration i, Process p) : this(i.GetWholeMilliseconds(), p) { }

        public void Update()
        {
            if (timer.Repeat())
                scheduler.Schedule();
        }
    }
}