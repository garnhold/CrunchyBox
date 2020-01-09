using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class BinSchedule : ISchedule
    {
        private long milliseconds_per_bin;

        private int current_index;
        private List<Queue<Process>> queues;

        private Timer timer;

        private int CalculateIndex(long timestamp)
        {
            return ((int)(timestamp / milliseconds_per_bin))
                .BindBetween(current_index, current_index + queues.Count - 1);
        }

        public BinSchedule(int n, long b)
        {
            milliseconds_per_bin = b;

            current_index = 0;
            queues = new List<Queue<Process>>();
            queues.AddRepeated(() => new Queue<Process>(), n);

            timer = new Timer();
        }

        public BinSchedule(int n, Duration b) : this(n, b.GetWholeMilliseconds()) { }

        public void Complete(long timestamp)
        {
            int target_index = CalculateIndex(timestamp);

            for(int i = current_index; i < target_index; i++)
            {
                Queue<Process> bin = queues.GetLooped(i);

                bin.Process(p => p());
                bin.Clear();
            }

            current_index = target_index;
        }

        public void Lookahead(long timestamp, long target_milliseconds)
        {
            if (target_milliseconds >= 1)
            {
                int target_index = CalculateIndex(timestamp);

                timer.RestartSetDurationInMilliseconds(target_milliseconds);

                for(int i = current_index; i < target_index; i++)
                {
                    Queue<Process> bin = queues.GetLooped(i);

                    while (bin.IsNotEmpty())
                    {
                        bin.Dequeue()();

                        if (timer.IsTimeOver())
                            return;
                    }
                }
            }
        }

        public void ScheduleProcess(long timestamp, Process process)
        {
            queues.GetLooped(CalculateIndex(timestamp)).Enqueue(process);
        }
    }
}