using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class ListPool<T> : Pool<List<T>>
    {
        public ListPool()
            : base(
                l => { },
                l => l.Clear(),
                () => new List<T>()
            ) { }
    }
}