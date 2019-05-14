using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class LinkedPeriodicProcessManager<PERIODIC_PROCESS_TYPE> : LinkedPeriodicProcessManager
    {
        public void Add(long milliseconds, Process process)
        {
            Add<PERIODIC_PROCESS_TYPE>(milliseconds, process);
        }
    }

    public class LinkedPeriodicProcessManager
    {
        private bool is_running;
        private object link_lock;

        private List<PeriodicProcess> processes;

        public LinkedPeriodicProcessManager()
        {
            is_running = false;
            link_lock = new object();

            processes = new List<PeriodicProcess>();
        }

        public void Add(Type type, long milliseconds, Process process)
        {
            PeriodicProcess periodic_process = PeriodicProcess.Create(type, milliseconds, delegate() {
                lock (link_lock)
                {
                    process();
                }
            });

            processes.Add(periodic_process);

            if (is_running)
                periodic_process.Start();
        }
        public void Add<PERIODIC_PROCESS_TYPE>(long milliseconds, Process process)
        {
            Add(typeof(PERIODIC_PROCESS_TYPE), milliseconds, process);
        }

        public void Step()
        {
            processes.Process(p => p.Step());
        }

        public void Start()
        {
            is_running = true;
            processes.Process(p => p.Start());
        }

        public void StopClear()
        {
            is_running = false;
            processes.Process(p => p.StopClear());
        }
    }
}