using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Windows;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySack;

namespace CrunchySack_WPF
{
    public class PeriodicProcess_WPF : PeriodicProcess
    {
        private System.Windows.Threading.DispatcherTimer timer;

        public PeriodicProcess_WPF(long pm, Process p) : base(p)
        {
            timer = new System.Windows.Threading.DispatcherTimer();

            timer.Interval = TimeSpan.FromMilliseconds(pm);
            timer.Tick += delegate(object sender, EventArgs args) {
                ExecuteProcess();
            };
        }

        public PeriodicProcess_WPF(long pm) : this(pm, null) { }

        public PeriodicProcess_WPF(CrunchyDough.Duration d, Process p) : this(d.GetWholeMilliseconds(), p) { }
        public PeriodicProcess_WPF(CrunchyDough.Duration d) : this(d, null) { }

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