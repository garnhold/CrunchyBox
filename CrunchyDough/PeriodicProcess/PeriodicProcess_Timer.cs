using System;

namespace CrunchyDough
{
    public class PeriodicProcess_Timer : PeriodicProcess
    {
        private System.Timers.Timer timer;

        public PeriodicProcess_Timer(long pm, Process p) : base(p)
        {
            timer = new System.Timers.Timer(pm);
            timer.Elapsed += delegate(object sender, System.Timers.ElapsedEventArgs args) {
                ExecuteProcess();
            };
        }

        public PeriodicProcess_Timer(long pm) : this(pm, null) { }

        public PeriodicProcess_Timer(Duration d, Process p) : this(d.GetWholeMilliseconds(), p) { }
        public PeriodicProcess_Timer(Duration d) : this(d, null) { }

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