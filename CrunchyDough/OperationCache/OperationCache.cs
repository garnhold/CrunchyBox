using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class OperationCache<T, P1, P2, P3, P4, P5> : OperationCache<T, Tuple<P1, P2, P3, P4, P5>>
    {
        public OperationCache(string i, Operation<T, P1, P2, P3, P4, P5> o) : base(i, p => o(p.item1, p.item2, p.item3, p.item4, p.item5)) { }

        public T Fetch(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
        {
            return base.Fetch(Tuple.New(p1, p2, p3, p4, p5));
        }
    }

    public class OperationCache<T, P1, P2, P3, P4> : OperationCache<T, Tuple<P1, P2, P3, P4>>
    {
        public OperationCache(string i, Operation<T, P1, P2, P3, P4> o) : base(i, p => o(p.item1, p.item2, p.item3, p.item4)) { }

        public T Fetch(P1 p1, P2 p2, P3 p3, P4 p4)
        {
            return base.Fetch(Tuple.New(p1, p2, p3, p4));
        }
    }

    public class OperationCache<T, P1, P2, P3> : OperationCache<T, Tuple<P1, P2, P3>>
    {
        public OperationCache(string i, Operation<T, P1, P2, P3> o) : base(i, p => o(p.item1, p.item2, p.item3)) { }

        public T Fetch(P1 p1, P2 p2, P3 p3)
        {
            return base.Fetch(Tuple.New(p1, p2, p3));
        }
    }

    public class OperationCache<T, P1, P2> : OperationCache<T, Tuple<P1, P2>>
    {
        public OperationCache(string i, Operation<T, P1, P2> o) : base(i, p => o(p.item1, p.item2)) { }

        public T Fetch(P1 p1, P2 p2)
        {
            return base.Fetch(Tuple.New(p1, p2));
        }
    }

    public class OperationCache<T, P> : OperationCache
    {
        private Operation<T, P> operation;

        private T null_result;
        private bool has_null_result;

        private Dictionary<P, T> cached_results;

        private T Calculate(P parameter)
        {
            try
            {
                return operation(parameter);
            }
            catch (Exception exception)
            {
                throw new Exception("An exception occured during a " + GetId() + " cache calculation for " + parameter, exception);
            }
        }

        public OperationCache(string i, Operation<T, P> o) : base(i)
        {
            operation = o;

            null_result = default(T);
            has_null_result = false;

            cached_results = new Dictionary<P, T>();
        }

        public override void Clear()
        {
            null_result = default(T);
            has_null_result = false;

            cached_results.Clear();
        }

        public T Fetch(P parameter)
        {
            if (IsActive())
            {
                if (parameter != null)
                    return cached_results.GetOrCreateValue(parameter, p => Calculate(p));
                else
                {
                    if (has_null_result == false)
                    {
                        null_result = Calculate(parameter);
                        has_null_result = true;
                    }

                    return null_result;
                }
            }

            return Calculate(parameter);
        }
    }

    public class OperationCache<T> : OperationCache
    {
        private Operation<T> operation;

        private T result;
        private bool has_result;

        private T Calculate()
        {
            return operation();
        }

        public OperationCache(string i, Operation<T> o) : base(i)
        {
            operation = o;

            result = default(T);
            has_result = false;
        }

        public override void Clear()
        {
            result = default(T);
            has_result = false;
        }

        public T Fetch()
        {
            if (IsActive())
            {
                if (has_result == false)
                {
                    result = Calculate();
                    has_result = true;
                }

                return result;
            }

            return Calculate();
        }
    }

    public abstract class OperationCache : Cache
    {
        public OperationCache(string i) : base(i) { }
    }
}