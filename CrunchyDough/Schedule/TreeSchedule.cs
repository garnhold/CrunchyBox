using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class TreeSchedule : ISchedule
    {
        private long milliseconds_per_bin;

        private QueuePool<Process> pool;
        private SortedDictionary<long, Queue<Process>> queues;
        private List<long> keys_to_remove;

        private Timer timer;

        private void Walk(long timestamp, Operation<bool, KeyValuePair<long, Queue<Process>>> operation)
        {
            long index = timestamp / milliseconds_per_bin;

            foreach (KeyValuePair<long, Queue<Process>> pair in queues)
            {
                if (pair.Key > index)
                    return;

                if (operation(pair) == false)
                    return;

                keys_to_remove.Add(pair.Key);
                pool.DepositRaw(pair.Value);
            }

            keys_to_remove.Process(k => queues.Remove(k));
            keys_to_remove.Clear();
        }

        public TreeSchedule(long b)
        {
            milliseconds_per_bin = b;

            pool = new QueuePool<Process>();
            queues = new SortedDictionary<long, Queue<Process>>();
            keys_to_remove = new List<long>();

            timer = new Timer();
        }

        public TreeSchedule(Duration b) : this(b.GetWholeMilliseconds()) { }

        public void Complete(long timestamp)
        {
            Walk(timestamp, delegate(KeyValuePair<long, Queue<Process>> pair) {
                pair.Value.Process(p => p());
                return true;
            });
        }

        public void Lookahead(long timestamp, long target_milliseconds)
        {
            if (target_milliseconds >= 1)
            {
                timer.RestartSetDurationInMilliseconds(target_milliseconds);

                Walk(timestamp, delegate(KeyValuePair<long, Queue<Process>> pair) {
                    while (pair.Value.IsNotEmpty())
                    {
                        pair.Value.Dequeue()();

                        if (timer.IsTimeOver())
                            return false;
                    }

                    return true;
                });
            }
        }

        public void ScheduleProcess(long timestamp, Process process)
        {
            long index = timestamp / milliseconds_per_bin;

            queues.GetOrCreateValue(index, () => pool.WithdrawRaw()).Enqueue(process);
        }
    }
}