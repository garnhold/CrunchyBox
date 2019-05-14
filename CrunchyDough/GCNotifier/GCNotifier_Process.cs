using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class GCNotifier_Process : GCNotifier
    {
        private Process process;

        protected override void OnNotification()
        {
            if (process != null)
                process();
        }

        public GCNotifier_Process(Process p)
        {
            process = p;
        }
    }
}