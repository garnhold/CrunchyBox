using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Noodle;
    using Sack;
    
    public class PeriodicProcess_Gtk : PeriodicProcess
    {
        private uint handle;
        private bool is_running;

        private long milliseconds;

        public PeriodicProcess_Gtk(long pm, Process p) : base(p)
        {
            handle = 0;
            is_running = false;

            milliseconds = pm;
        }

        public PeriodicProcess_Gtk(long pm) : this(pm, null) { }

        public PeriodicProcess_Gtk(Duration d, Process p) : this(d.GetWholeMilliseconds(), p) { }
        public PeriodicProcess_Gtk(Duration d) : this(d, null) { }

        public override void Start()
        {
            if (is_running == false)
            {
                handle = GLib.Timeout.Add((uint)milliseconds, delegate() {
                    ExecuteProcess();
                    return true;
                });

                is_running = true;
            }
        }

        public override void StopClear()
        {
            if (is_running)
            {
                GLib.Timeout.Remove(handle);

                is_running = false;
            }
        }
    }
}