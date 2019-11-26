using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class WorkScheduler
    {
        private UnityEngine.Object requester;
        private Process process;

        private bool need_process;
        private bool has_scheduled;
        private long scheduled_delay;

        public WorkScheduler(UnityEngine.Object r, Process p)
        {
            requester = r;
            process = p;

            need_process = false;
            has_scheduled = false;
            scheduled_delay = 0;
        }

        public void Execute()
        {
            need_process = false;

            process();
        }

        public void Request(long delay)
        {
            need_process = true;

            if (has_scheduled == false || delay < scheduled_delay)
            {
                has_scheduled = true;
                scheduled_delay = delay;

                WorkSystem.GetInstance().Schedule(requester, scheduled_delay, delegate() {
                    has_scheduled = false;

                    if (need_process)
                        Execute();
                });
            }
        }
    }
}