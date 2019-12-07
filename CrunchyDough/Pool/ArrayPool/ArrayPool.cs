using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ArrayPool<T> : Pool<T[]>
    {
        static public readonly ArrayPool<T> GENERAL = new ArrayPool<T>(1024);

        public ArrayPool(int size)
            : base(
                q => { },
                q => { },
                () => new T[size]
            ) { }
    }
}