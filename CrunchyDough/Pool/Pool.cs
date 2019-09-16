using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class Pool<T>
    {
        private Pit<T> pit;

        private Process<T> withdraw_process;
        private Process<T> deposite_process;

        public Pool(Process<T> w, Process<T> d, Operation<T> c)
        {
            pit = new Pit<T>(c);

            withdraw_process = w;
            deposite_process = d;
        }

        public Pool(int number, Process<T> w, Process<T> d, Operation<T> c) : this(w, d, c)
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

            withdraw_process(item);
            return item;
        }

        public void DepositRaw(T item)
        {
            pit.Push(item);

            deposite_process(item);
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