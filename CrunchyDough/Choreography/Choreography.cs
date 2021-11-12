using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class Choreography
    {
        private List<TaskCompletionSource<bool>> incoming_sources;
        private List<TaskCompletionSource<bool>> active_sources;

        public Choreography()
        {
            incoming_sources = new List<TaskCompletionSource<bool>>();
            active_sources = new List<TaskCompletionSource<bool>>();
        }

        public void Clear()
        {
            incoming_sources.Process(s => s.SetCanceled());
            incoming_sources.Clear();

            active_sources.Process(s => s.SetCanceled());
            active_sources.Clear();
        }

        public void Update()
        {
            active_sources.Process(s => s.SetResult(true));

            Swap.Values(ref active_sources, ref incoming_sources);
            incoming_sources.Clear();
        }

        public Task ForUpdate()
        {
            TaskCompletionSource<bool> source = new TaskCompletionSource<bool>();

            incoming_sources.Add(source);
            return source.Task;
        }

        public async Task ForCondition(Predicate predicate)
        {
            while (predicate() == false)
                await ForUpdate();
        }

        public async Task ForDuration(Duration duration)
        {
            Timer timer = new Timer(duration).StartAndGet();

            await ForCondition(() => timer.IsTimeOver());
        }
        public async Task ForMilliseconds(long milliseconds)
        {
            await ForDuration(Duration.Milliseconds(milliseconds));
        }
        public async Task ForSeconds(float seconds)
        {
            await ForDuration(Duration.Seconds(seconds));
        }
    }
}
