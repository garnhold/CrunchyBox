using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBaker
{
    public abstract class TimedTaskComparer_DataProcessing<T> : TimedTaskComparer
    {
        private TimedTask_DataProcess<T> process_a;
        private TimedTask_DataProcess<T> process_b;

        private Operation<IEnumerable<T>> data_operation;

        protected override void RunIterationInternal()
        {
            IEnumerable<T> data = data_operation.Execute();

            process_a.SetData(data);
            process_b.SetData(data);
        }

        public TimedTaskComparer_DataProcessing(int f, int p, Operation<IEnumerable<T>> d, TimedTask_DataProcess<T> a, TimedTask_DataProcess<T> b) : base(f, p, a, b)
        {
            process_a = a;
            process_b = b;

            data_operation = d;
        }
    }
}