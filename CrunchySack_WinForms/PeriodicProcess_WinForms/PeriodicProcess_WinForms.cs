using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Windows.Forms;

namespace Crunchy.Sack.WinForms
{
    using Dough;
    using Noodle;
    using Sack;
    
    public class PeriodicProcess_WinForms : PeriodicProcess
    {
        private System.Windows.Forms.Timer timer;

        public PeriodicProcess_WinForms(int pm, Process p) : base(p)
        {
            timer = new System.Windows.Forms.Timer();

            timer.Interval = pm;
            timer.Tick += delegate(object sender, EventArgs args) {
                ExecuteProcess();
            };
        }

        public PeriodicProcess_WinForms(int pm) : this(pm, null) { }

        public PeriodicProcess_WinForms(Duration d, Process p) : this((int)d.GetWholeMilliseconds(), p) { }
        public PeriodicProcess_WinForms(Duration d) : this(d, null) { }

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