using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Baker
{
    using Dough;
    
    public class TimedTask_DataProcess<T> : TimedTask
    {
        private List<T> data;
        private Process<T> process;

        protected override void RunInternal()
        {
            foreach (T item in data)
                process(item);
        }

        public TimedTask_DataProcess(Process<T> p)
        {
            data = new List<T>();
            process = p;
        }

        public void SetData(IEnumerable<T> input)
        {
            data.Set(input);
        }
    }
}