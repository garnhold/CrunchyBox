using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class Pool<T>
    {
        private Pit<T> pit;
        private Process<T> prepare_process;

        public Pool(Process<T> p, Operation<T> c)
        {
            pit = new Pit<T>(c);
            prepare_process = p;
        }

        public Pool(int number, Process<T> p, Operation<T> c) : this(p, c)
        {
            Preallocate(number);
        }

        public void Preallocate(int number)
        {
            pit.Preallocate(number);
        }

        public T WithdrawRaw()
        {
            T item = pit.Pop();

            prepare_process(item);
            return item;
        }

        public void DepositRaw(T item)
        {
            pit.Push(item);
        }

        public Pooled<T> Withdraw()
        {
            return new Pooled<T>(WithdrawRaw(), this);
        }

        public void Use(Process<T> process)
        {
            using (Pooled<T> pooled = Withdraw())
                process(pooled.Get());
        }

        public J Use<J>(Operation<J, T> operation)
        {
            using (Pooled<T> pooled = Withdraw())
                return operation(pooled.Get());
        }
    }
}