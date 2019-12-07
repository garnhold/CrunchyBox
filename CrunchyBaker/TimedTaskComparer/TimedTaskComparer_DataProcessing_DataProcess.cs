using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Baker
{
    using Dough;
    
    public class TimedTaskComparer_DataProcessing_DataProcess<T> : TimedTaskComparer_DataProcessing<T>
    {
        public TimedTaskComparer_DataProcessing_DataProcess(int f, int p, Operation<IEnumerable<T>> d, Process<T> a, Process<T> b)
            : base(f, p, d, new TimedTask_DataProcess<T>(a), new TimedTask_DataProcess<T>(b))
        {
        }
    }
}