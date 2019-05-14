using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class ListPool<T> : ContainerPool<T, List<T>>
    {
        static public readonly ListPool<T> GENERAL = new ListPool<T>(1024);

        protected override void ClearContainer(List<T> container)
        {
            container.Clear();
        }

        protected override List<T> CreateContainer(int starting_size)
        {
            return new List<T>(starting_size);
        }

        public ListPool(int starting_size) : base(starting_size) { }
        public ListPool(int starting_size, int number) : base(starting_size, number) { }
    }
}