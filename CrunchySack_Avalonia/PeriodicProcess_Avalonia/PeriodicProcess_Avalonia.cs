using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Avalonia;
using Avalonia.Threading;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;
    
    public class PeriodicProcess_Avalonia : PeriodicProcess
    {
        private DispatcherTimer timer;

        public PeriodicProcess_Avalonia(long pm, Process p) : base(p)
        {
            timer = new DispatcherTimer();

            timer.Interval = TimeSpan.FromMilliseconds(pm);
            timer.Tick += delegate(object sender, EventArgs args) {
                ExecuteProcess();
            };
        }

        public PeriodicProcess_Avalonia(long pm) : this(pm, null) { }

        public PeriodicProcess_Avalonia(Duration d, Process p) : this(d.GetWholeMilliseconds(), p) { }
        public PeriodicProcess_Avalonia(Duration d) : this(d, null) { }

        public override void Start()
        {
            timer.Start();
        }

        public override void StopClear()
        {
            timer.Stop();
        }
    }
}