using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class FrameProcess
    {
        private Frame frame;
        private Process start_process;
        private Process update_process;

        public FrameProcess(Process s, Process u)
        {
            start_process = s;
            update_process = u;
        }

        public FrameProcess(Process u) : this(null, u) { }

        public void Touch()
        {
            if (frame.IsNotCurrent())
            {
                if (frame.IsNotRecent() && start_process != null)
                    start_process();

                update_process();
                frame = Frame.GetCurrentFrame();
            }
        }
    }
}