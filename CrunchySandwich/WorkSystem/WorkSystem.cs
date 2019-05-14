using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class WorkSystem : Subsystem
    {
        private LazySchedule<Process> processes;

        static public WorkSystem GetInstance()
        {
            return Subsystem.GetInstance<WorkSystem>();
        }

        public WorkSystem()
        {
            processes = new LazySchedule<Process>(Duration.Hertz(70.0f), Duration.Minutes(0.5f), p => p());
        }

        public override void Update()
        {
            processes.Work();
        }

        public override void UpdateInEditor()
        {
            processes.Work();
        }

        public void Schedule(long allowance, Process process)
        {
            processes.AddIn(allowance, process);
        }
    }
}