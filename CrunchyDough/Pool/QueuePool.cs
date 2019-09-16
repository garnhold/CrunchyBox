using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class QueuePool<T> : Pool<Queue<T>>
    {
        public QueuePool()
            : base(
                q => { },
                q => q.Clear(),
                () => new Queue<T>()
            ) { }
    }
}