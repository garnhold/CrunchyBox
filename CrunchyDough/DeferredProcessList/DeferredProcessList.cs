using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class DeferredProcessList
    {
        private List<Process> processor;
        private List<Process> accumulator;

        public DeferredProcessList()
        {
            processor = new List<Process>();
            accumulator = new List<Process>();
        }

        public void Clear()
        {
            processor.Clear();
            accumulator.Clear();
        }

        public void Defer(Process process)
        {
            accumulator.Add(process);
        }

        public void ProcessDeferred()
        {
            do
            {
                Swap.Values(ref processor, ref accumulator);

                processor.Process(p => p());
                processor.Clear();
            }
            while (accumulator.IsNotEmpty());
        }
    }
}