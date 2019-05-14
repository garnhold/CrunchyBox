using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class OperationCache<T, P1, P2, P3, P4, P5> : OperationCache<T, Tuple<P1, P2, P3, P4, P5>>
    {
        public OperationCache(Operation<T, P1, P2, P3, P4, P5> o) : base(p => o(p.item1, p.item2, p.item3, p.item4, p.item5)) { }

        public T Fetch(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
        {
            return base.Fetch(Tuple.New(p1, p2, p3, p4, p5));
        }
    }

    public class OperationCache<T, P1, P2, P3, P4> : OperationCache<T, Tuple<P1, P2, P3, P4>>
    {
        public OperationCache(Operation<T, P1, P2, P3, P4> o) : base(p => o(p.item1, p.item2, p.item3, p.item4)) { }

        public T Fetch(P1 p1, P2 p2, P3 p3, P4 p4)
        {
            return base.Fetch(Tuple.New(p1, p2, p3, p4));
        }
    }

    public class OperationCache<T, P1, P2, P3> : OperationCache<T, Tuple<P1, P2, P3>>
    {
        public OperationCache(Operation<T, P1, P2, P3> o) : base(p => o(p.item1, p.item2, p.item3)) { }

        public T Fetch(P1 p1, P2 p2, P3 p3)
        {
            return base.Fetch(Tuple.New(p1, p2, p3));
        }
    }

    public class OperationCache<T, P1, P2> : OperationCache<T, Tuple<P1, P2>>
    {
        public OperationCache(Operation<T, P1, P2> o) : base(p => o(p.item1, p.item2)) { }

        public T Fetch(P1 p1, P2 p2)
        {
            return base.Fetch(Tuple.New(p1, p2));
        }
    }

    public class OperationCache<T, P> : OperationCache
    {
        private Operation<T, P> operation;
        private Dictionary<P, OperationCacheItem<T>> cached_results;

        public OperationCache(Operation<T, P> o)
        {
            operation = o;
            cached_results = new Dictionary<P, OperationCacheItem<T>>();
        }

        public override void Clear()
        {
            cached_results.Clear();
        }

        public T Fetch(P parameter)
        {
            if (IsActive())
            {
                OperationCacheItem<T> item;

                if (cached_results.TryGetValue(parameter, out item) == false)
                    item = cached_results.AddAndGet(parameter, new OperationCacheItem<T>(operation(parameter)));

                return item.GetData();
            }

            return operation(parameter);
        }
    }

    public class OperationCache<T> : OperationCache
    {
        private Operation<T> operation;
        private OperationCacheItem<T> item;

        public OperationCache(Operation<T> o)
        {
            operation = o;
        }

        public override void Clear()
        {
            item = null;
        }

        public T Fetch()
        {
            if (IsActive())
            {
                if (item == null)
                    item = new OperationCacheItem<T>(operation());

                return item.GetData();
            }

            return operation();
        }
    }

    public abstract class OperationCache : Cache
    {
    }
}