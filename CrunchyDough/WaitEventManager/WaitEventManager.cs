using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class WaitEventManager
    {
        private HashSet<TryProcess> processes;
        private List<TryProcess> incoming_processes;

        static private WaitEventManager INSTANCE;
        static public WaitEventManager GetInstance()
        {
            if (INSTANCE == null)
                INSTANCE = new WaitEventManager();

            return INSTANCE;
        }

        private WaitEventManager()
        {
            processes = new HashSet<TryProcess>();
            incoming_processes = new List<TryProcess>();
        }

        public void Update()
        {
            processes.RemoveWhere(p => p());

            processes.AddRange(incoming_processes);
            incoming_processes.Clear();
        }

        public void RegisterWaitEvent(TryProcess process)
        {
            incoming_processes.Add(process);
        }
        public void UnregisterWaitEvent(TryProcess process)
        {
            processes.Remove(process);
            incoming_processes.Remove(process);
        }
    }
}