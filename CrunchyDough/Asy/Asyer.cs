using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class Asyer
    {
        private List<TaskCompletionSource<bool>> active_sources;
        private List<TaskCompletionSource<bool>> incoming_sources;

        static public Asyer Start(Process process)
        {
            Asyer asyer = new Asyer();

            asyer.Use(process);
            return asyer;
        }

        public Asyer()
        {
            active_sources = new List<TaskCompletionSource<bool>>();
            incoming_sources = new List<TaskCompletionSource<bool>>();
        }

        public void Clear()
        {
            active_sources.Process(s => s.SetCanceled());
            active_sources.Clear();

            incoming_sources.Process(s => s.SetCanceled());
            incoming_sources.Clear();
        }

        public void Use(Process process)
        {
            AsyerManager.GetInstance().Use(this, process);
        }

        public void Update()
        {
            Use(() => active_sources.Process(s => s.SetResult(true)));

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

        public async Task ForTemporal(TemporalEvent temporal)
        {
            await ForCondition(() => temporal.IsTimeOver());
        }
        public async Task ForTemporal(TemporalDuration temporal)
        {
            await ForTemporal(temporal.GetAsTemporalEvent());
        }
    }
}
