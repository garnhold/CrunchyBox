using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Android;
using Android.App;
using Android.Views;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Noodle;
    using Sack;
    
    public class PeriodicProcess_Android : PeriodicProcess
    {
        private long interval;
        private bool is_running;
        private bool is_registered;

        private Process recursive_process;

        private void Register()
        {
            if (is_registered == false)
            {
                AndroidExtensions.RunOnUiThreadDelayed(recursive_process, interval);
                is_registered = true;
            }
        }

        public PeriodicProcess_Android(long pm, Process p) : base(p)
        {
            interval = pm;

            recursive_process = delegate() {
                is_registered = false;

                if (is_running)
                {
                    try { ExecuteProcess(); }
                    finally { Register(); }
                }
            };
        }

        public PeriodicProcess_Android(long pm) : this(pm, null) { }

        public PeriodicProcess_Android(Duration d, Process p) : this(d.GetWholeMilliseconds(), p) { }
        public PeriodicProcess_Android(Duration d) : this(d, null) { }

        public override void Start()
        {
            is_running = true;
            Register();
        }

        public override void StopClear()
        {
            is_running = false;
        }
    }
}