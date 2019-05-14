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
        private long allowance;

        private bool has_scheduled;

        public WorkScheduler(long a, Process p)
        {
            process = p;
            allowance = a;

            has_scheduled = false;
        }

        public WorkScheduler(Duration m, Process p) : this(m.GetWholeMilliseconds(), p) { }

        public void Schedule()
        {
            if (has_scheduled == false)
            {
                has_scheduled = true;

                WorkSystem.GetInstance().Schedule(allowance, delegate() {
                    has_scheduled = false;

                    process();
                });
            }
        }
    }
}