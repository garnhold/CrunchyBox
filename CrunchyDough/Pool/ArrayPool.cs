using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class ArrayPool<T> : ContainerPool<T, T[]>
    {
        static public readonly ArrayPool<T> GENERAL = new ArrayPool<T>(1024);

        protected override void ClearContainer(T[] container)
        {
        }

        protected override T[] CreateContainer(int starting_size)
        {
            return new T[starting_size];
        }

        public ArrayPool(int starting_size) : base(starting_size) { }
        public ArrayPool(int starting_size, int number) : base(starting_size, number) { }
    }
}