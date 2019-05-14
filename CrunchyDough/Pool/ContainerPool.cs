using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public abstract class ContainerPool<ELEMENT_TYPE, CONTAINER_TYPE> where CONTAINER_TYPE : IEnumerable<ELEMENT_TYPE>
    {
        private Pool<CONTAINER_TYPE> pool;

        protected abstract void ClearContainer(CONTAINER_TYPE container);
        protected abstract CONTAINER_TYPE CreateContainer(int starting_size);

        public ContainerPool(int starting_size)
        {
            pool = new Pool<CONTAINER_TYPE>(c => ClearContainer(c), () => CreateContainer(starting_size));
        }

        public ContainerPool(int starting_size, int number) : this(starting_size)
        {
            Preallocate(number);
        }

        public void Preallocate(int number)
        {
            pool.Preallocate(number);
        }

        public CONTAINER_TYPE WithdrawRaw()
        {
            return pool.WithdrawRaw();
        }

        public void DepositRaw(CONTAINER_TYPE item)
        {
            pool.DepositRaw(item);
        }

        public Pooled<CONTAINER_TYPE> Withdraw()
        {
            return pool.Withdraw();
        }

        public void Use(Process<CONTAINER_TYPE> process)
        {
            pool.Use(process);
        }

        public J Use<J>(Operation<J, CONTAINER_TYPE> operation)
        {
            return pool.Use(operation);
        }
    }
}