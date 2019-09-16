using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class WorkScheduler
    {
        private Process process;
        private long delay;

        private bool has_scheduled;

        public WorkScheduler(long d, Process p)
        {
            process = p;
            delay = d;

            has_scheduled = false;
        }

        public WorkScheduler(Duration m, Process p) : this(m.GetWholeMilliseconds(), p) { }

        public void Schedule()
        {
            if (has_scheduled == false)
            {
                has_scheduled = true;

                WorkSystem.GetInstance().Schedule(delay, delegate() {
                    has_scheduled = false;

                    process();
                });
            }
        }
    }
}