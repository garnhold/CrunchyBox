using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public class SyncroManager
    {
        private object update_lock;
        private Thread execution_thread;

        private List<Process> deferred_call_queue;

        public SyncroManager()
        {
            update_lock = new object();
            deferred_call_queue = new List<Process>();
        }

        public void Update()
        {
            lock (update_lock)
            {
                execution_thread = System.Threading.Thread.CurrentThread;

                while (deferred_call_queue.IsNotEmpty())
                    deferred_call_queue.PopLast()();
            }
        }

        public void ExecuteFunction(FunctionInstance instance, object[] arguments)
        {
            lock (update_lock)
            {
                if (System.Threading.Thread.CurrentThread == execution_thread)
                    instance.Execute(true, arguments);
                else
                {
                    deferred_call_queue.Add(delegate() {
                        instance.Execute(true, arguments);
                    });
                }
            }
        }
    }
}