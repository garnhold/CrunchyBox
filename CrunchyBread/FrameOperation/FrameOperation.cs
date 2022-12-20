using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class FrameOperation<T>
    {
        private T result;

        private Frame frame;
        private Process start_process;
        private Operation<T> update_operation;

        public FrameOperation(Process s, Operation<T> u)
        {
            start_process = s;
            update_operation = u;
        }

        public FrameOperation(Operation<T> u) : this(null, u) { }

        public T Touch()
        {
            if (frame.IsNotCurrent())
            {
                if (frame.IsNotRecent() && start_process != null)
                    start_process();

                result = update_operation();
                frame = Frame.GetCurrentFrame();
            }

            return result;
        }
    }
}